using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace FinanceSim
{
  public abstract class BaseCollectionEditorAggregateViewModel<T> : BaseNotifyPropertyChanged
    where T: IHasIdViewModel
  {
    private readonly BaseCollectionEditorViewModel[] _collections;
    private T[] _currentItems = null;

    public BaseCollectionEditorAggregateViewModel(params BaseCollectionEditorViewModel[] collections)
    {
      _collections = collections;
      Array.ForEach(_collections, c => c.CollectionChanged += OnCollectionChanged);
      UpdateCollection();
    }

    public ObservableCollectionEx<T> Items { get; } = new ObservableCollectionEx<T>();

    public T First() => Items.FirstOrDefault();

    public T Find(string id) => Items.FirstOrDefault(i => string.Equals(i.Id, id));

    public virtual bool IsValid(T item) => true;

    public IEnumerable<T> GetItems() => _collections.SelectMany(c => c.Items.Cast<T>());

    private void UpdateCollection()
    {
      BeforeCollectionUpdated(_currentItems);
      _currentItems = GetItems().ToArray();
      Items.Set(_currentItems.Where(t => IsValid(t)));
      AfterCollectionUpdated(_currentItems);
    }

    protected virtual void AfterCollectionUpdated(T[] state)
    {
    }

    protected virtual void BeforeCollectionUpdated(T[] state)
    {
    }

    private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
      UpdateCollection();
    }
  }
}
