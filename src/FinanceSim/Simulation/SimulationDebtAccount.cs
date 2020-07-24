using System;

namespace FinanceSim
{
  public class SimulationDebtAccount : SimulationAccount, ISimulationBill
  {
    public SimulationDebtAccount(DateTime start, Debt debt)
      : base(debt)
    {
      Interest = debt.Interest;
      Due = new SimulationDueInfo(start, debt.Due);

      AccountId = debt.AccountId;
      Payment = debt.Payment;
    }

    public string AccountId { get; }
    public decimal Payment { get; set; }
    public decimal Interest { get; set; }

    public SimulationDueInfo Due { get; }

    public bool IsPaidOff { get; set; }

    public override void Withdraw(SimulationState state, DateTime date, decimal amount) => 
      Balance += amount;

    public override void Deposit(SimulationState state, DateTime date, decimal amount) => 
      Balance -= amount;

    public override void ProcessInterest(SimulationState state, DateTime date)
    {
      if (Interest > 0 && !IsPaidOff && date >= Due.Start)
      {
        var amount = (Interest / 12m) * Balance;
        state.Withdraw(date, this, $"Interest ({Interest:P2})", amount);
      }
    }

    public void Process(SimulationState state, DateTime date)
    {
      if (IsPaidOff)
      {
        return;
      }

      var payment = Payment;
      if (state.IsSnowball && state.SnowballTarget == this)
      {
        payment += state.SnowballAmount;
      }

      state.Deposit(date, this, "Payment", payment);
      state.Withdraw(date, AccountId, Name, payment);
    }
  }
}
