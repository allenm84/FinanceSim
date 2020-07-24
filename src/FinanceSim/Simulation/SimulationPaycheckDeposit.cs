namespace FinanceSim
{
  public class SimulationPaycheckDeposit
  {
    public SimulationPaycheckDeposit(PaycheckDeposit deposit)
    {
      AccountId = deposit.AccountId;
      Amount = deposit.Amount;
      Id = deposit.Id;
      Name = deposit.Name;
    }

    public string AccountId { get; set; }
    public decimal Amount { get; set; }
    public string Id { get; }
    public string Name { get; }
  }
}
