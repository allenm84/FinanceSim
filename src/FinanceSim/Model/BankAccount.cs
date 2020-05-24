namespace FinanceSim
{
  public class BankAccount : IAccount
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public BankAccountType Type { get; set; }
    public decimal Balance { get; set; }
    public decimal APY { get; set; }
  }
}
