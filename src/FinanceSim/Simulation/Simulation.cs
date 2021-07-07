using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceSim
{
  public static class Simulation
  {
    public static async Task<Dictionary<IAccount, List<SimulationResultItem>>> Run(SimulationSetup setup,
      Profile profile)
    {
      var cloned = await Task.Run(profile.Clone);
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
  }
}
