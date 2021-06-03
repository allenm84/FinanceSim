namespace FinanceSim
{
  public class SimulationNoticeBoard : BaseNotifyPropertyChanged, IAccount
  {
    public const string AccountId = "208a5a33-0d6b-4824-b1e8-e19a43f49331";
    public string Name => "Notices";
    public decimal Balance { get; set; }
    public string Id => AccountId;
  }
}
