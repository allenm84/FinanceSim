using System.Collections.Generic;
using System.Linq;

namespace FinanceSim
{
  public class SimulationResultsViewModel : BaseNotifyPropertyChanged
  {
    public SimulationResultsViewModel(Dictionary<IAccount, List<SimulationResultItem>> model)
    {
      Results = new ObservableCollectionEx<SimulationResultItemViewModel>();

      var items = model.OrderBy(k => GetTypeKey(k.Key)).ThenBy(k => k.Key.Name);
      foreach (var kvp in items)
      {
        Results.Add(new SimulationResultItemViewModel(kvp.Key, kvp.Value));
      }
    }

    public ObservableCollectionEx<SimulationResultItemViewModel> Results { get; }

    public static int GetTypeKey(IAccount account)
    {
      return account switch
      {
        SimulationNoticeBoard => 0,
        SimulationBankAccount => 1,
        SimulationDebtAccount => 2,
        _ => 3,
      };
    }
  }
}
