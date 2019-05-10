using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public static class Simulation
  {
    public static async Task<Dictionary<IAccount, List<Transaction>>> Run(DateTime start, DateTime end, Profile profile)
    {
      return await Task.Run(() => run(start, end, profile));
    }

    private static Dictionary<IAccount, List<Transaction>> run(DateTime start, DateTime end, Profile profile)
    {
      // sanitize the input
      start = start.Date;
      end = end.Date;

      // create the simulation state
      var state = new SimulationState(profile);

      // advance all of the due dates
      state.Init(start);

      // go through the provided date range
      for (DateTime i = start; i <= end; i = i.AddDays(1))
      {
        DistributePaychecks(i, state);
        ApplyInterest(i, state);
        MakePayments(i, state);
      }

      // return all of the transactions
      return state.Transactions;
    }

    private static void DistributePaychecks(DateTime date, SimulationState state)
    {
      foreach (var p in state.Profile.Paychecks)
      {
        if (p.IsDue(date, state))
        {
          var amount = p.Total;
          foreach (var d in p.Deposits)
          {
            var value = d.Amount;
            state.Deposit(value, d.AccountId, date, d.Name);
            amount -= value;
          }

          state.Deposit(amount, p.AccountId, date, p.Name);
          state.Advance(p);
        }
      }
    }

    private static void ApplyInterest(DateTime date, SimulationState state)
    {
      if (!date.IsEndOfMonth())
      {
        return;
      }

      foreach (var d in state.Profile.Debts)
      {
        state.ApplyInterest(date, d);
      }
    }

    private static void MakePayments(DateTime date, SimulationState state)
    {
      foreach (var b in state.Profile.Bills)
      {
        if (b.IsDue(date, state))
        {
          state.Withdraw(b.Payment, b.AccountId, date, b.Name);
          state.Advance(b);
        }
      }

      foreach (var d in state.Profile.Debts)
      {
        if (d.IsDue(date, state))
        {
          state.Withdraw(d.Payment, d.AccountId, date, d.Name);
          state.MakePayment(date, d);
          state.Advance(d);
        }
      }
    }
  }
}
