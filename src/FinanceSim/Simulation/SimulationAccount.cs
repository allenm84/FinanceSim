using System;

namespace FinanceSim
{
  public abstract class SimulationAccount : IAccount, ISimulationItem
  {
    protected SimulationAccount(IAccount account)
    {
      Balance = account.Balance;
      Id = account.Id;
      Name = account.Name;
    }

    public decimal Balance { get; set; }
    public string Id { get; }
    public string Name { get; }

    public abstract void ProcessInterest(SimulationState state, DateTime date);

    public abstract void Deposit(SimulationState state, DateTime date, decimal amount);
    public abstract void Withdraw(SimulationState state, DateTime date, decimal amount);
  }
}
