using System;
using System.Collections.Generic;
using System.Linq;

namespace FinanceSim
{
  public class SimulationPaycheck : ISimulationItem
  {
    private readonly List<SimulationPaycheckDeposit> _deposits;
    private readonly SimulationDueInfo _dueDates;

    public SimulationPaycheck(DateTime start, Paycheck paycheck)
    {
      _dueDates = new SimulationDueInfo(start, paycheck.Due);
      _deposits = paycheck.Deposits.Select(d => new SimulationPaycheckDeposit(d)).ToList();

      Id = paycheck.Id;
      AccountId = paycheck.AccountId;
      Name = paycheck.Name;
      Total = paycheck.Total;
    }

    public string Id { get; }
    public string AccountId { get; set; }
    public string Name { get; }
    public decimal Total { get; set; }

    public SimulationDueInfo Due => _dueDates;

    public void Process(SimulationState state, DateTime date)
    {
      var total = Total;
      foreach (var deposit in _deposits)
      {
        state.Deposit(date, deposit.AccountId, deposit.Name, deposit.Amount);
        total -= deposit.Amount;
      }

      state.Deposit(date, AccountId, Name, total);
    }
  }
}
