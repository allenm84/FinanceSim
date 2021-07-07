using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;

namespace FinanceSim
{
  public class SimulationResultItemViewModel : BaseNotifyPropertyChanged
  {
    public SimulationResultItemViewModel(IAccount account, IEnumerable<SimulationResultItem> items)
    {
      Name = account.Name;

      var itemsEx = new ObservableCollectionEx<SimulationResultItem>();
      itemsEx.Set(items);

      Items = CollectionViewSource.GetDefaultView(itemsEx);

      GroupCommand = new DelegateCommand(DoGroup, CanGroup);
      UnGroupCommand = new DelegateCommand(UnGroup, CanUnGroup);
    }

    public string Name { get; }
    public ICollectionView Items { get; }

    public DelegateCommand GroupCommand { get; }
    public DelegateCommand UnGroupCommand { get; }

    private void RefreshCommands()
    {
      GroupCommand.Refresh();
      UnGroupCommand.Refresh();
    }

    private bool CanGroup() =>
      Items.GroupDescriptions.Count == 0;

    private void DoGroup()
    {
      Items.GroupDescriptions.Add(new PropertyGroupDescription(nameof(SimulationResultItem.Name)));
      RefreshCommands();
    }

    private bool CanUnGroup() =>
      Items.GroupDescriptions.Count > 0;

    private void UnGroup()
    {
      Items.GroupDescriptions.Clear();
      RefreshCommands();
    }
  }
}
