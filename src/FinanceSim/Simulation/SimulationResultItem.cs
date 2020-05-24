using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;

namespace FinanceSim
{
  public class SimulationResultItem : BaseNotifyPropertyChanged
  {
    private readonly ObservableCollectionEx<SimulationTransaction> _items = new ObservableCollectionEx<SimulationTransaction>();

    public SimulationResultItem(IAccount account, List<SimulationTransaction> transactions)
    {
      Name = account.Name;

      _items = new ObservableCollectionEx<SimulationTransaction>();
      _items.Set(transactions);

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
      Items.GroupDescriptions.Add(new PropertyGroupDescription(nameof(SimulationTransaction.Name)));
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
