using System;

namespace FinanceSim
{
  public class SimulationTransaction : ISimulationItem
  {
    private readonly SimulationDueInfo _dueDates;

    public SimulationTransaction(DateTime start, Transaction transaction)
    {
      _dueDates = new SimulationDueInfo(start, transaction.Due);

      Id = transaction.Id;
      Name = transaction.Name;
      Amount = transaction.Amount;
      FromId = transaction.FromId;
      ToId = transaction.ToId;
    }

    public string Id { get; }
    public string Name { get; }
    public decimal Amount { get; set; }
    public string FromId { get; set; }
    public string ToId { get; set; }

    public SimulationDueInfo Due => _dueDates;

    public void Process(SimulationState state, DateTime date)
    {
      state.Withdraw(date, FromId, Name, Amount);
      state.Deposit(date, ToId, Name, Amount);
    }
  }
}