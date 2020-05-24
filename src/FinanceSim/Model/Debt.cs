namespace FinanceSim
{
  public class Debt : Bill, IAccount
  {
    public decimal Interest { get; set; }
    public decimal Balance { get; set; }
  }
}
