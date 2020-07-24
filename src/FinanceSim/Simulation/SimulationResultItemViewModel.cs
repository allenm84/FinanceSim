using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;

namespace FinanceSim
{
  public class SimulationResultItemViewModel : BaseNotifyPropertyChanged
  {
    private readonly ObservableCollectionEx<SimulationResultItem> _items = new ObservableCollectionEx<SimulationResultItem>();

    public SimulationResultItemViewModel(IAccount account, List<SimulationResultItem> items)
    {
      Name = account.Name;

      _items = new ObservableCollectionEx<SimulationResultItem>();
      _items.Set(items);

      Items = CollectionViewSource.GetDefaultView(_items);

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
