using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class SimulationState
  {
    private SimulationSnowballState _snowball;

    public SimulationState(Profile profile)
    {
      Profile = profile;

      var accounts = profile.OfType<IAccount>().ToArray();
      Balances = accounts.ToDictionary(k => k.Id, v => v.Balance);
      Transactions = accounts.ToDictionary(k => k, v => new List<Transaction>(), IHasIdComparer<IAccount>.Instance);

      var withDueDates = profile.OfType<IHasDueInfo>().ToArray();
      NextDueDates = withDueDates.ToDictionary(k => k, v => v.Due.Seed, IHasIdComparer<IHasDueInfo>.Instance);
    }

    public Profile Profile { get; }
    public Dictionary<string, decimal> Balances { get; }
    public Dictionary<IAccount, List<Transaction>> Transactions { get; }
    public Dictionary<IHasDueInfo, DateTime> NextDueDates { get; }

    public SimulationSnowballState Snowball => _snowball;

    public bool IsPaidOff => 
      (_snowball == null) || 
      Profile.Debts.All(d => _snowball.PaidOff.Contains(d.Id));

    private static DateTime Sanitize(DateTime value, DueInfo due)
    {
      // it is possible that the last Advance made the day not match the seed. If
      // that is the case, and its possible to fix, then try to do so now
      if (value.Day != due.Seed.Day)
      {
        int days = DateTime.DaysInMonth(value.Year, value.Month);
        value = new DateTime(value.Year, value.Month, Math.Min(days, due.Seed.Day));
      }
      return value;
    }

    public void Init(DateTime min)
    {
      // advance all the due dates until the date is >= the min date
      foreach (var due in Profile.OfType<IHasDueInfo>())
      {
        // these are only due once!
        if (due.Due.Type == DueType.Once)
          continue;

        // advance until next due date
        while (NextDueDates.TryGetValue(due, out DateTime next) && (next < min || next < due.Due.Start))
        {
          if (!Advance(due))
          {
            break;
          }
        }
      }
    }

    public void InitSnowball(DateTime min, decimal snowball, SnowballDebtOrder order)
    {
      Init(min);
      _snowball = new SimulationSnowballState(snowball, order);

      Transactions.Add(_snowball, new List<Transaction>());
      LogSnowballState(min, $"Start: {_snowball.Order?.Current?.Name}");
    }

    public bool Advance(IHasDueInfo info)
    {
      var currentNext = NextDueDates[info];

      var due = info.Due;
      switch (due.Type)
      {
        case DueType.Daily:
          // due every "N" days, from the seed
          currentNext = currentNext.AddDays(due.Period);
          break;
        case DueType.Weekly:
          // due every "N" weeks, from the seed
          currentNext = currentNext.AddDays(7 * due.Period);
          break;
        case DueType.Monthly:
          // due every "N" months from the seed
          currentNext = Sanitize(currentNext.AddMonths(due.Period), due);
          break;
        case DueType.Yearly:
          // due every "N" years from the seed
          currentNext = Sanitize(currentNext.AddYears(due.Period), due);
          break;
      }

      if (info.Due.End < currentNext)
      {
        // the next due date is past the desired end date...so we're done
        return false;
      }

      NextDueDates[info] = currentNext;
      return true;
    }

    public bool IsDue(DateTime date, IHasDueInfo info)
    {
      return NextDueDates[info] == date;
    }

    public void Deposit(decimal value, string accountId, DateTime date, string name)
    {
      // make sure we start with a positive value
      value = Math.Sign(value) * value;

      var account = GetAccount(accountId);
      if (account is Debt)
      {
        // deposit means different things for debts (so make it negative)
        value *= -1;
      }

      Apply(value, account, date, name);
    }

    public void Withdraw(decimal value, string accountId, DateTime date, string name)
    {
      // make sure we start with a positive value
      value = Math.Sign(value) * value;

      var account = GetAccount(accountId);
      if (!(account is Debt))
      {
        // withdraw means different things for debts (so keep the positive)
        value *= -1;
      }

      Apply(value, account, date, name);
    }

    public decimal MakePayment(DateTime date, Debt debt)
    {
      var payment = debt.Payment;

      if (_snowball != null)
      {
        // if the specified debt is the target
        var isTarget = _snowball.Order.IsCurrent(debt);

        // apply the extra to the payment (if needed)
        if (isTarget)
        {
          payment = payment + _snowball.Amount;
        }

        // the snowball relies on paying a bill off
        var currentBalance = Balances[debt.Id];
        if (currentBalance < payment)
        {
          // pay off the bill
          if (_snowball.PaidOff.Add(debt.Id))
          {
            // make a payment to match the current balance
            payment = currentBalance;
          }
          else
          {
            // don't make a payment; we already paid it off
            payment = 0;
          }

          // if this is the target bill, then update the snowball
          if (isTarget)
          {
            var old = debt;
            var current = debt;

            do
            {
              if (_snowball.Order.MoveNext())
              {
                current = _snowball.Order.Current;
              }
              else
              {
                current = null;
                break;
              }
            }
            while (_snowball.PaidOff.Contains(current.Id));

            if (current != null)
            {
              _snowball.Amount += old.Payment;
              LogSnowballState(date, $"From: '{old.Name}', To: '{current.Name}' (+{old.Payment:c2})");
            }
            else
            {
              LogSnowballState(date, $"End: {old.Name}");
            }
          }
          else if (payment > 0)
          {
            // the bill has been paid off, but it isn't the target. Add the
            // amount to the snowball
            _snowball.Amount += debt.Payment;
            LogSnowballState(date, $"Paid Off: '{debt.Name}' (+{debt.Payment:c2})");
          }
        }
      }

      // a payment reduces the balance
      if (payment > 0)
      {
        Apply(-payment, debt, date, "Payment");
      }

      // return the actual payment that was made
      return payment;
    }

    public void ApplyInterest(DateTime date, Debt debt)
    {
      if (debt.Interest > 0)
      {
        decimal monthly = debt.Interest / 12;
        decimal amount = Balances[debt.Id] * monthly;
        if (amount > 0)
        {
          Apply(amount, debt, date, $"{debt.Interest:P2} Interest");
        }
      }
    }

    private void Apply(decimal value, IAccount account, DateTime date, string name)
    {
      // update the balance
      decimal currentBalance = Balances[account.Id];
      currentBalance += value;
      Balances[account.Id] = currentBalance;

      // add a transaction for the account
      Transactions[account].Add(new Transaction
      {
        Amount = value,
        Balance = currentBalance,
        Date = date,
        Name = name,
      });
    }

    private void LogSnowballState(DateTime date, string text)
    {
      if (_snowball != null)
      {
        var log = Transactions[_snowball];
        log.Add(new Transaction
        {
          Amount = _snowball.Amount,
          Balance = 0,
          Date = date,
          Name = text
        });
      }
    }

    private IAccount GetAccount(string id) => Transactions.Keys.Single(k => string.Equals(k.Id, id));
  }
}
