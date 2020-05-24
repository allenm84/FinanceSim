namespace FinanceSim
{
  public class SimulationNoticeBoard : BaseNotifyPropertyChanged, IAccount
  {
    public string Name => "Notices";
    public decimal Balance { get; set; }
    public string Id => "208a5a33-0d6b-4824-b1e8-e19a43f49331";
  }
}
