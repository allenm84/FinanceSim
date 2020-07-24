using System;

namespace FinanceSim
{
  public class SimulationBill : ISimulationItem, ISimulationBill
  {
    public SimulationBill(DateTime start, Bill bill)
    {
      Due = new SimulationDueInfo(start, bill.Due);

      Id = bill.Id;
      Name = bill.Name;
      AccountId = bill.AccountId;
      Payment = bill.Payment;
    }

    public string Id { get; }
    public string Name { get; }
    public string AccountId { get; set; }
    public decimal Payment { get; set; }

    public SimulationDueInfo Due { get; }

    public void Process(SimulationState state, DateTime date)
    {
      state.Withdraw(date, AccountId, Name, Payment);
    }
  }
}
