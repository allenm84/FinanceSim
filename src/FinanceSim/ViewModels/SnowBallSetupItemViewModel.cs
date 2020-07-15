namespace FinanceSim
{
  public class SnowBallSetupItemViewModel : BaseNotifyPropertyChanged
  {
    public SnowBallSetupItemViewModel(DebtItemViewModel debt)
    {
      Debt = debt;
      Name = Debt?.Name;
      Balance = Debt?.Balance ?? 0m;
    }

    public DebtItemViewModel Debt { get; }
    public string Name { get; }
    public decimal Balance { get; }
  }
}
