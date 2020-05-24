namespace FinanceSim
{
  public class PaycheckDeposit : BaseNamedWithoutId
  {
    public string AccountId { get; set; }
    public decimal Amount { get; set; }
  }
}
