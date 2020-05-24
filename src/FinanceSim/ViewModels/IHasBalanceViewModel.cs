namespace FinanceSim
{
  public interface IHasBalanceViewModel : IHasIdViewModel
  {
    decimal Balance { get; }
  }
}
