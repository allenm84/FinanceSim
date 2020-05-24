using System.Collections.Generic;

namespace FinanceSim
{
  public class SimulationResults : BaseNotifyPropertyChanged
  {
    public SimulationResults(Dictionary<IAccount, List<SimulationTransaction>> model)
    {
      Results = new ObservableCollectionEx<SimulationResultItem>();
      foreach (var kvp in model)
      {
        Results.Add(new SimulationResultItem(kvp.Key, kvp.Value));
      }
    }

    public ObservableCollectionEx<SimulationResultItem> Results { get; }
  }
}
