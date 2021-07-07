using System.Collections.Generic;

namespace FinanceSim
{
  public class ScheduleResultViewModel : BaseNotifyPropertyChanged
  {
    public ScheduleResultViewModel(IEnumerable<SimulationResultItem> items)
    {
      Items = new ObservableCollectionEx<SimulationResultItem>();
      Items.Set(items);
    }

    public ObservableCollectionEx<SimulationResultItem> Items { get; }
  }
}
