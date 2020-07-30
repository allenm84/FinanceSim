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

      Type = debt.Type;
      AccountId = debt.AccountId;
      Payment = debt.Payment;

      State = SimulationDebtAccountState.Due;
    }

    public DebtType Type { get; }
    public string AccountId { get; }
    public decimal Payment { get; set; }
    public decimal Interest { get; set; }
    public SimulationDueInfo Due { get; }
    public SimulationDebtAccountState State { get; private set; }
    private bool IsPaidOff => (State == SimulationDebtAccountState.PaidOff);

    public bool SetState(SimulationDebtAccountState state)
    {
      if (state != State)
      {
        State = state;
        return true;
      }

      return false;
    }

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

      if (payment > Balance)
      {
        // if we make this payment; we'll overpay
        payment = Balance;
      }

      state.Deposit(date, this, "Payment", payment);
      state.Withdraw(date, AccountId, Name, payment);
    }
  }
}
