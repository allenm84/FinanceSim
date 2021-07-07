using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace FinanceSim
{
  public abstract class BaseCollectionEditorAggregateViewModel<T> : BaseNotifyPropertyChanged
    where T : IHasIdViewModel
  {
    private readonly BaseCollectionEditorViewModel[] _collections;

    protected BaseCollectionEditorAggregateViewModel(params BaseCollectionEditorViewModel[] collections)
    {
      _collections = collections;
      Array.ForEach(_collections, c => c.CollectionChanged += OnCollectionChanged);
      UpdateCollection();
    }

    public ObservableCollectionEx<T> Items { get; } = new();

    public T First() => Items.FirstOrDefault();

    public T Find(string id) => Items.FirstOrDefault(i => string.Equals(i.Id, id));

    protected virtual bool IsValid(T item) => true;

    public IEnumerable<T> GetItems() => _collections.SelectMany(c => c.Items.Cast<T>());

    protected void UpdateCollection()
    {
      Items.Set(GetItems().Where(IsValid));
    }

    private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
      UpdateCollection();
    }
  }
}
