namespace FinanceSim
{
  public class SnowBallSetupItemViewModel : BaseNotifyPropertyChanged
  {
    public SnowBallSetupItemViewModel(DebtItemViewModel debt)
    {
      Debt = debt;
      Name = Debt?.Name;
    }

    public DebtItemViewModel Debt { get; }
    public string Name { get; }
  }
}
