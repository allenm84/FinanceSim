using System;
using System.Collections.Generic;
using System.Linq;

namespace FinanceSim
{
  public class SimulationState
  {
    private delegate void AccountActionDelegate(SimulationAccount account, SimulationState state, DateTime date, decimal amount);

    private readonly SimulationNoticeBoard _noticeAccount = new SimulationNoticeBoard();

    public SimulationState(Profile profile, SimulationSetup setup)
    {
      IsSnowball = setup.UseSnowball;

      Accounts = profile.Accounts.Select(a => new SimulationBankAccount(a)).ToDictionary(a => a.Id);
      Bills = profile.Bills.Select(b => new SimulationBill(setup.Start, b)).ToDictionary(b => b.Id);
      Debts = profile.Debts.Select(d => new SimulationDebtAccount(setup.Start, d)).ToDictionary(d => d.Id);
      Paychecks = profile.Paychecks.Select(p => new SimulationPaycheck(setup.Start, p)).ToDictionary(p => p.Id);
      Transactions = profile.Transactions.Select(t => new SimulationTransaction(setup.Start, t)).ToDictionary(t => t.Id);
      Events = profile.Events.All().ToLookup(e => e.Date);

      SnowballPool = new Queue<SimulationDebtAccount>(Debts.Values
        .Select((d, i) => (debt: d, order: GetDebtOrder(d, profile.Snowball, i)))
        .OrderBy(t => t.order)
        .Select(t => t.debt));
      SnowballTarget = SnowballPool.SafeDequeue();
      SnowballAmount = profile.Snowball.InitialAmount;

      Results = new Dictionary<IAccount, List<SimulationResultItem>>();

      AddToSnowball(setup.Start, 0);
    }

    public bool IsSnowball { get; }
    public Dictionary<string, SimulationBankAccount> Accounts { get; }
    public Dictionary<string, SimulationBill> Bills { get; }
    public Dictionary<string, SimulationDebtAccount> Debts { get; }
    public Dictionary<string, SimulationPaycheck> Paychecks { get; }
    public Dictionary<string, SimulationTransaction> Transactions { get; }
    public ILookup<DateTime, BaseEvent> Events { get; }

    public SimulationDebtAccount SnowballTarget { get; set; }
    public Queue<SimulationDebtAccount> SnowballPool { get; }
    public decimal SnowballAmount { get; set; }

    public Dictionary<IAccount, List<SimulationResultItem>> Results { get; }

    private static int GetDebtOrder(SimulationDebtAccount debt, SnowBallSetup setup, int defaultOrder)
    {
      int index = Array.IndexOf(setup.DebtOrder, debt.Id);
      if (index < 0)
      {
        index = defaultOrder;
      }
      return index;
    }

    private void AddResultItem(IAccount key, DateTime date, decimal amount, string name)
    {
      if (!Results.TryGetValue(key, out var items))
      {
        items = new List<SimulationResultItem>();
        Results[key] = items;
      }

      items.Add(new SimulationResultItem
      {
        Amount = amount,
        Balance = key.Balance,
        Date = date,
        Name = name,
      });
    }

    public bool ShouldKeepGoing()
    {
      return !IsSnowball || SnowballPool.Count > 0;
    }

    public void UpdateSnowball(DateTime date)
    {
      if (!IsSnowball)
      {
        return;
      }

      // go through the pool until we find the next target or the pool is drained
      var currentSnowballTarget = SnowballTarget;
      while (CanBeSnowballTarget(SnowballTarget) == false)
      {
        SnowballTarget = SnowballPool.SafeDequeue();
      }

      if (currentSnowballTarget != SnowballTarget)
      {
        AddNotice(date, $"Snowball Target Updated({currentSnowballTarget.Name} => {SnowballTarget?.Name})");
      }
    }

    private static bool? CanBeSnowballTarget(SimulationDebtAccount debt)
    {
      if (debt == null)
      {
        return null;
      }

      return debt.State == SimulationDebtAccountState.Due;
    }

    public void AddNotice(DateTime date, string text)
    {
      AddResultItem(_noticeAccount, date, 0, text);
    }

    public void PayOff(DateTime date, SimulationDebtAccount debt)
    {
      switch (debt.Type)
      {
        case DebtType.Revolving:
          {
            // a revolving debt doesn't get paid off, it just
            // becomes inelligible to be a snowball target
            if (debt.SetState(SimulationDebtAccountState.None))
            {
              AddNotice(date, $"{debt.Name} balance to {0m:C2}");
            }
            break;
          }
        default:
          {
            // any other debt type gets paid off and added 
            // to the snowball
            if (debt.SetState(SimulationDebtAccountState.PaidOff))
            {
              AddNotice(date, $"{debt.Name} paid off");

              if (IsSnowball)
              {
                // add the debt payment to the snowball
                AddToSnowball(date, debt.Payment);
              }
            }
            break;
          }
      }
    }

    public void AddToPaycheckTotal(DateTime date, string id, decimal amount)
    {
      if (Paychecks.TryGetValue(id, out var paycheck))
      {
        paycheck.Total += amount;
        AddNotice(date, $"Paycheck Update({paycheck.Name} to {paycheck.Total:C2})");
      }
    }

    public void AddToSnowball(DateTime date, decimal amount)
    {
      var oldSnowball = SnowballAmount;
      SnowballAmount += amount;

      var sign = amount < 0 ? '-' : '+';
      var absAmount = Math.Abs(amount);

      if (absAmount > 0)
      {
        AddNotice(date, $"Snowball(Amount = ({oldSnowball:C2} {sign} {absAmount:C2}) = {SnowballAmount:C2})");
      }
      else
      {
        AddNotice(date, $"Snowball(Amount = {SnowballAmount:C2})");
      }
    }

    public void ChangeBillPayment(DateTime date, string id, decimal newPayment)
    {
      var bill = GetBill(id);
      if (bill != null)
      {
        var oldPayment = bill.Payment;
        bill.Payment = newPayment;

        AddNotice(date, $"Payment Update ({bill.Name} to {newPayment:C2})");

        var diff = newPayment - oldPayment;
        if (diff > 0)
        {
          // take money away from the snowball to pay for this
          AddToSnowball(date, -diff);
        }
      }
    }

    private ISimulationBill GetBill(string id)
    {
      if (Bills.TryGetValue(id, out var bill))
      {
        return bill;
      }

      if (Debts.TryGetValue(id, out var debt))
      {
        return debt;
      }

      return null;
    }

    public IEnumerable<SimulationAccount> GetAccounts()
    {
      foreach (var account in Accounts.Values)
      {
        yield return account;
      }

      foreach (var debt in Debts.Values)
      {
        yield return debt;
      }
    }

    public SimulationAccount GetAccount(string id)
    {
      if (Debts.TryGetValue(id, out var debt))
      {
        return debt;
      }

      if (Accounts.TryGetValue(id, out var account))
      {
        return account;
      }

      return null;
    }

    private static void DepositDelegate(SimulationAccount account, SimulationState state, DateTime date, decimal amount)
      => account.Deposit(state, date, amount);

    private static void WithdrawDelegate(SimulationAccount account, SimulationState state, DateTime date, decimal amount)
      => account.Withdraw(state, date, amount);

    private void DoAction(AccountActionDelegate action, DateTime date, SimulationAccount account, string name, decimal amount)
    {
      var b1 = account.Balance;
      action.Invoke(account, this, date, amount);
      var b2 = account.Balance;
      var sign = b2.CompareTo(b1);
      AddResultItem(account, date, amount * sign, name);
    }

    public void Deposit(DateTime date, string accountId, string name, decimal amount)
    {
      var account = GetAccount(accountId);
      if (account != null)
      {
        Deposit(date, account, name, amount);
      }
    }

    public void Deposit(DateTime date, SimulationAccount account, string name, decimal amount)
    {
      DoAction(DepositDelegate, date, account, name, amount);
    }

    public void Withdraw(DateTime date, string accountId, string name, decimal amount)
    {
      var account = GetAccount(accountId);
      if (account != null)
      {
        Withdraw(date, account, name, amount);
      }
    }

    public void Withdraw(DateTime date, SimulationAccount account, string name, decimal amount)
    {
      DoAction(WithdrawDelegate, date, account, name, amount);
    }
  }
}
