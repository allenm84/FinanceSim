using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
