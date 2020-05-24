namespace FinanceSim
{
  public interface IAccount : IHasName
  {
    decimal Balance { get; set; }
  }
}
