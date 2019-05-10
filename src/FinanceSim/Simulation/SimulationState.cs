using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class SimulationState
  {
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

    public void MakePayment(DateTime date, Debt debt)
    {
      // a payment reduces the balance
      Apply(-debt.Payment, debt, date, "Payment");
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

    private IAccount GetAccount(string id) => Transactions.Keys.Single(k => string.Equals(k.Id, id));
  }
}
