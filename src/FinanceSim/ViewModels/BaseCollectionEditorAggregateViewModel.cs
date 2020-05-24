using System;
using System.Collections.Specialized;
using System.Linq;

namespace FinanceSim
{
  public abstract class BaseCollectionEditorAggregateViewModel<T> : BaseNotifyPropertyChanged
    where T: IHasIdViewModel
  {
    private readonly BaseCollectionEditorViewModel[] _collections;

    public BaseCollectionEditorAggregateViewModel(params BaseCollectionEditorViewModel[] collections)
    {
      _collections = collections;
      Array.ForEach(_collections, c => c.CollectionChanged += OnCollectionChanged);
      UpdateCollection();
    }

    public ObservableCollectionEx<T> Items { get; } = new ObservableCollectionEx<T>();

    public T First() => Items.FirstOrDefault();

    public T Find(string id) => Items.FirstOrDefault(i => string.Equals(i.Id, id));

    private void UpdateCollection()
    {
      var all_items = _collections.SelectMany(c => c.Items.Cast<T>());
      Items.Set(all_items);
    }

    private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
      UpdateCollection();
    }
  }
}
