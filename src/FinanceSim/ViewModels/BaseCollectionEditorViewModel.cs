using System.Collections;
using System.Collections.Specialized;

namespace FinanceSim
{
  public abstract class BaseCollectionEditorViewModel : BaseNotifyPropertyChanged
  {
    public BaseCollectionEditorViewModel()
    {
      AddCommand = new DelegateCommand(DoAdd, CanAdd);
      RemoveCommand = new DelegateCommand(DoRemove, CanRemove);
    }

    public abstract event NotifyCollectionChangedEventHandler CollectionChanged;

    public abstract IList Items { get; }

    public DelegateCommand AddCommand { get; }
    public DelegateCommand RemoveCommand { get; }

    protected abstract bool CanAdd();
    protected abstract void DoAdd();

    protected abstract bool CanRemove();
    protected abstract void DoRemove();
  }
}
