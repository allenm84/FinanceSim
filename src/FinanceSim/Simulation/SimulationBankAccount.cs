using System;

namespace FinanceSim
{
  public class SimulationBankAccount : SimulationAccount
  {
    public SimulationBankAccount(BankAccount account) 
      : base(account)
    {
      APY = account.APY;
    }

    public decimal APY { get; set; }

    public override void Withdraw(SimulationState state, DateTime date, decimal amount)
    {
      Balance -= amount;

      if (Balance < 0)
      {
        state.AddNotice(date, $"ALERT: {Name} has balance of {Balance:C2}");
      }
    }

    public override void Deposit(SimulationState state, DateTime date, decimal amount) => 
      Balance += amount;

    public override void ProcessInterest(SimulationState state, DateTime date)
    {
      if (APY > 0)
      {
        decimal amount = (APY / 12m) * Balance;
        state.Deposit(date, this, $"APY({APY:P2})", amount);
      }
    }
  }
}
