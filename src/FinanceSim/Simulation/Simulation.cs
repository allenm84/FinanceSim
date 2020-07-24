using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceSim
{
  public static class Simulation
  {
    public static async Task<Dictionary<IAccount, List<SimulationResultItem>>> Run(SimulationSetup setup, Profile profile)
    {
      var cloned = await Task.Run(() => profile.Clone());
      return await Task.Run(() => RunInternal(setup, cloned));
    }

    private static Dictionary<IAccount, List<SimulationResultItem>> RunInternal(SimulationSetup setup, Profile profile)
    {
      var state = new SimulationState(profile, setup);
      var start = setup.Start.Date;
      var end = setup.End.Date;

      for (DateTime date = start; date <= end; date = date.AddDays(1))
      {
        // before anything else, make sure we do the events
        var events = state.Events[date];
        foreach (var item in events)
        {
          ProcessEvent(state, date, item);
        }

        // if it is the end of the month, then interest hits
        if (date.IsEndOfMonth())
        {
          foreach (var account in state.GetAccounts())
          {
            account.ProcessInterest(state, date);
          }
        }

        // deposit any paychecks
        var paychecks = state.Paychecks.Values.Where(p => p.Due.Current == date);
        foreach (var paycheck in paychecks)
        {
          paycheck.Process(state, date);
          paycheck.Due.Next();
        }

        // pay the bills
        var bills = state.Bills.Values.Where(b => b.Due.Current == date);
        foreach (var bill in bills)
        {
          bill.Process(state, date);
          bill.Due.Next();
        }

        // pay the debts
        var debts = state.Debts.Values.Where(d => d.Due.Current == date);
        foreach (var debt in debts)
        {
          debt.Process(state, date);
          debt.Due.Next();
        }

        // process the transactions
        var transactions = state.Transactions.Values.Where(t => t.Due.Current == date);
        foreach (var transaction in transactions)
        {
          transaction.Process(state, date);
          transaction.Due.Next();
        }

        // if we get here and a debt has a zero balance, then it is paid off
        foreach (var debt in state.Debts.Values)
        {
          if (debt.Balance <= 0)
          {
            state.PayOff(date, debt);
          }
        }

        // if needed, update the snowball
        state.UpdateSnowball(date);

        // quit if we need to
        if (!state.ShouldKeepGoing())
        {
          break;
        }
      }

      return state.Results;
    }

    private static void ProcessEvent(SimulationState state, DateTime date, BaseEvent item)
    {
      switch (item)
      {
        case AdjustPaycheckTotalEvent adjustPaycheckTotal:
          {
            state.AddToPaycheckTotal(date, adjustPaycheckTotal.PaycheckId, adjustPaycheckTotal.Amount);
            break;
          }
        case AdjustSnowballAmountEvent adjustSnowball:
          {
            state.AddToSnowball(date, adjustSnowball.Amount);
            break;
          }
        case ChangeBillPaymentEvent changeBillPayment:
          {
            state.ChangeBillPayment(date, changeBillPayment.BillId, changeBillPayment.NewPayment);
            break;
          }
      }
    }

    private static Dictionary<IAccount, List<SimulationResultItem>> RunInternally(SimulationSetup setup, Profile profile)
    {
      var state = InitializeState(setup, profile);

      // while there are debts remaining
      for (DateTime date = state.Start; KeepGoing(date); date = date.AddDays(1))
      {
        // if needed, add the interest to the debt balances
        ApplyIterest(date, state);

        // apply any events that may be pending
        ApplyEvents(date, state);

        // process the remaining items
        for (int i = 0; i < state.RemainingItems.Count; ++i)
        {
          var item = state.RemainingItems[i];
          var next = state.NextDueDate[item.Id];

          if (next == date)
          {
            var (remove, newSnowball) = ProcessDueItem(date, item, state);

            if (remove)
            {
              state.RemainingItems.RemoveAt(i);
              --i;

              if (newSnowball && SelectNextSnowballTarget(date, state))
              {
                state.IsDone = true;
                break;
              }
            }

            var nextDueDate = DueInfoHelper.Advance(next, item.Due);
            state.NextDueDate[item.Id] = nextDueDate;

            if (nextDueDate >= item.Due.End)
            {
              // this item is done
              state.RemainingItems.RemoveAt(i);
              --i;

              if (newSnowball && SelectNextSnowballTarget(date, state))
              {
                state.IsDone = true;
                break;
              }
            }
          }
        }

        if (state.IsDone)
        {
          break;
        }
      }

      return state.Transactions;

      bool KeepGoing(DateTime currentDate)
      {
        if (state.UseSnowball)
        {
          return state.RemainingItems.OfType<Debt>().Any();
        }
        else
        {
          return currentDate <= setup.End;
        }
      }
    }

    private static void ApplyEvents(DateTime date, SimulationLookupState state)
    {
      date = date.Date;
      foreach (var item in state.Events)
      {
        if (item.Date.Date == date)
        {
          item.Apply(state);
        }
      }
    }

    private static bool SelectNextSnowballTarget(DateTime date, SimulationLookupState state)
    {
      if (state.SnowballTargets.Any())
      {
        var nextSnowballTarget = state.SnowballTargets.Dequeue();
        while (!state.RemainingItems.Contains(nextSnowballTarget))
        {
          if (state.SnowballTargets.Any())
          {
            nextSnowballTarget = state.SnowballTargets.Dequeue();
          }
          else
          {
            return true;
          }
        }

        SnowballTargetChanged(state, date, state.CurrentSnowballTarget, nextSnowballTarget);
        state.CurrentSnowballTarget = nextSnowballTarget;
      }
      else
      {
        return true;
      }

      return false;
    }

    private static (bool remove, bool newSnowball) ProcessDueItem(DateTime date, IHasDueInfo item, SimulationLookupState state)
    {
      bool remove = false;
      bool newSnowball = false;

      if (item is Paycheck paycheck)
      {
        var amount = paycheck.Total;
        foreach (var d in paycheck.Deposits)
        {
          var value = d.Amount;
          IncreaseBalance(state, date, d.AccountId, d.Name, value);
          amount -= value;
        }

        IncreaseBalance(state, date, paycheck.AccountId, paycheck.Name, amount);
      }
      else if (item is Debt debt)
      {
        var payment = debt.Payment;
        if (state.UseSnowball && state.CurrentSnowballTarget == debt)
        {
          payment += state.SnowballAmount;
          newSnowball = true;
        }

        // take the payment from the account
        DecreaseBalance(state, date, debt.AccountId, debt.Name, payment);

        // reduce the balance since we made a payment
        var newBalance = state.AccountBalances[debt.Id] - payment;
        if (newBalance <= 0m)
        {
          newBalance = 0;
          PaidOff(state, date, debt);

          if (state.UseSnowball)
          {
            AdjustSnowball(state, date, debt.Payment, debt.Name);
          }

          remove = true;
        }

        // report the payment
        AddTransaction(state, debt, date, "Payment", payment, newBalance);

        // a payment decreases the balance
        state.AccountBalances[debt.Id] = newBalance;
      }
      else if (item is Bill bill)
      {
        DecreaseBalance(state, date, bill.AccountId, bill.Name, bill.Payment);
      }
      else if (item is Transaction transaction)
      {
        var from = state.Accounts[transaction.FromId];
        var to = state.Accounts[transaction.ToId];

        if (from is Debt)
        {
          // we're taking money from a debt ...
          IncreaseBalance(state, date, from.Id, transaction.Name, transaction.Amount);
        }
        else
        {
          // we're taking money from a non-debt ...
          DecreaseBalance(state, date, from.Id, transaction.Name, transaction.Amount);
        }

        if (to is Debt)
        {
          // ... and giving it to debt; we're using "from" to make a payment
          DecreaseBalance(state, date, to.Id, transaction.Name, transaction.Amount);
        }
        else
        {
          // ... and giving it to a non debt; we're using "from" to make a deposit
          IncreaseBalance(state, date, to.Id, transaction.Name, transaction.Amount);
        }
      }

      return (remove, newSnowball);
    }

    public static void AdjustSnowball(SimulationLookupState state, DateTime date, decimal diff, string source = null)
    {
      var text = "Snowball Update";
      if (!string.IsNullOrWhiteSpace(source))
      {
        text = $"{text} (Source: {source})";
      }

      state.SnowballAmount += diff;
      AddTransaction(state, state.NoticeAccount, date, text, diff, state.SnowballAmount);
    }

    public static void SnowballTargetChanged(SimulationLookupState state, DateTime date, Debt current, Debt next)
    {
      AddTransaction(state, state.NoticeAccount, date, $"Snowball Target ({current.Name} => {next.Name})", 0, 0);
    }

    public static void AddNotice(SimulationLookupState state, DateTime date, string text, decimal amount = 0, decimal balance = 0)
    {
      AddTransaction(state, state.NoticeAccount, date, text, amount, balance);
    }

    public static void PaidOff(SimulationLookupState state, DateTime date, Debt debt)
    {
      AddTransaction(state, state.NoticeAccount, date, $"Paid Off: {debt.Name}", 0, 0);
    }

    public static void NegativeBalance(SimulationLookupState state, DateTime date, IAccount account)
    {
      AddTransaction(state, state.NoticeAccount, date, $"ALERT: {account.Name}", 0, state.AccountBalances[account.Id]);
    }

    private static void IncreaseBalance(SimulationLookupState state, DateTime date, string id, string name, decimal amount)
    {
      state.AccountBalances[id] += amount;
      var newBalance = state.AccountBalances[id];
      AddTransaction(state, state.Accounts[id], date, name, amount, newBalance);
    }

    private static void DecreaseBalance(SimulationLookupState state, DateTime date, string id, string name, decimal amount)
    {
      var account = state.Accounts[id];
      state.AccountBalances[id] -= amount;

      var newBalance = state.AccountBalances[id];
      AddTransaction(state, account, date, name, -amount, newBalance);
      if (newBalance < 0)
      {
        NegativeBalance(state, date, account);
      }
    }

    private static SimulationLookupState InitializeState(SimulationSetup setup, Profile profile)
    {
      var state = new SimulationLookupState();
      state.Transactions = new Dictionary<IAccount, List<SimulationResultItem>>();
      state.Start = setup.Start;
      state.RemainingItems = profile.OfType<IHasDueInfo>().ToList();
      state.NextDueDate = InitializeDueDates(state);
      state.Accounts = profile.OfType<IAccount>().ToDictionary(a => a.Id);
      state.AccountBalances = profile.OfType<IAccount>().ToDictionary(k => k.Id, v => v.Balance);
      state.UseSnowball = setup.UseSnowball;
      state.SnowballAmount = profile.Snowball?.InitialAmount ?? 0m;
      state.SnowballTargets = new Queue<Debt>(state.RemainingItems
       .OfType<Debt>()
       .OrderBy(d => GetSnowballOrder(d, profile.Snowball)));
      state.CurrentSnowballTarget = state.SnowballTargets.Dequeue();
      state.Events = GenerateEvents(profile, state).ToList();
      return state;
    }

    private static IEnumerable<SimulationEvent> GenerateEvents(Profile profile, SimulationLookupState state)
    {
      var events = profile.Events;
      if (events != null)
      {
        var bills = profile.OfType<Bill>().ToDictionary(b => b.Id);
        var paychecks = profile.OfType<Paycheck>().ToDictionary(p => p.Id);

        foreach (var item in events.AdjustSnowballAmountEvents)
        {
          yield return SimulationEvent.AdjustSnowball(item.Date, item.Amount);
        }

        foreach (var item in events.ChangeBillPaymentEvents)
        {
          if (bills.TryGetValue(item.BillId, out var bill))
          {
            yield return SimulationEvent.ChangeBillPayment(item.Date, bill, item.NewPayment);
          }
        }

        foreach (var item in events.AdjustPaycheckTotalEvents)
        {
          if (paychecks.TryGetValue(item.PaycheckId, out var paycheck))
          {
            yield return SimulationEvent.AdjustPaycheckTotal(item.Date, paycheck, item.Amount);
          }
        }
      }
    }

    private static Dictionary<string, DateTime> InitializeDueDates(SimulationLookupState state)
    {
      var nextDueDate = new Dictionary<string, DateTime>();
      for (int i = state.RemainingItems.Count - 1; i > -1; --i)
      {
        var item = state.RemainingItems[i];
        var next = item.Due.Seed;
        while (next < state.Start || next < item.Due.Start)
        {
          next = DueInfoHelper.Advance(next, item.Due);
          if (next >= item.Due.End)
          {
            // the item is no longer due
            state.RemainingItems.RemoveAt(i);
            break;
          }
        }
        nextDueDate[item.Id] = next;
      }
      return nextDueDate;
    }

    private static int GetSnowballOrder(Debt debt, SnowBallSetup snowball)
    {
      if (snowball == null)
      {
        return (int)Math.Round(debt.Balance);
      }

      int index = Array.IndexOf(snowball.DebtOrder, debt.Id);
      return (index < 0) ? int.MaxValue : index;
    }

    private static void ApplyIterest(DateTime date, SimulationLookupState state)
    {
      var daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
      if (date.Day == daysInMonth)
      {
        foreach (var debt in state.RemainingItems.OfType<Debt>().Where(d => d.Interest > 0))
        {
          // don't apply interest if the debt hasn't started yet
          if (debt.Due.Start > date)
          {
            continue;
          }

          var monthly = debt.Interest / 12;
          var interest = state.AccountBalances[debt.Id] * monthly;
          if (interest > 0)
          {
            // interest increases the balance
            decimal newBalance = state.AccountBalances[debt.Id] + interest;
            state.AccountBalances[debt.Id] = newBalance;
            AddTransaction(state, debt, date, $"{debt.Interest:P2} Interest", interest, newBalance);
          }
        }
      }
    }

    private static void AddTransaction(SimulationLookupState state, IAccount account, DateTime date, string text, decimal amount, decimal balance)
    {
      if (!state.Transactions.TryGetValue(account, out var transactions))
      {
        transactions = new List<SimulationResultItem>();
        state.Transactions[account] = transactions;
      }

      transactions.Add(new SimulationResultItem
      {
        Amount = amount,
        Balance = balance,
        Date = date,
        Name = text,
      });
    }
  }
}
