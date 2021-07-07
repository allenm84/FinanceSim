using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace FinanceSim
{
  public abstract class CollectionEditorViewModel<TViewModel, TModel> : BaseCollectionEditorViewModel
    where TViewModel : IHasIdViewModel
  {
    private readonly ObservableCollectionEx<TViewModel> _items = new();
    private TViewModel _selectedItem;

    protected CollectionEditorViewModel(ProfileViewModel profile, IEnumerable<TModel> items)
    {
      Profile = profile;

      if (items != null)
      {
        _items.Set(items.Select(ToViewModel));
      }

      SelectedItem = _items.FirstOrDefault();
      _items.CollectionChanged += _items_CollectionChanged;
    }

    public override event NotifyCollectionChangedEventHandler CollectionChanged;

    protected ProfileViewModel Profile { get; }

    public override IList Items => _items;

    public bool IsEnabled => SelectedItem != null;

    public TViewModel SelectedItem
    {
      get => _selectedItem;
      set
      {
        SetField(ref _selectedItem, value);
        RemoveCommand.Refresh();
        FirePropertyChanged(nameof(IsEnabled));
      }
    }

    public TViewModel First() => _items.FirstOrDefault();

    public IEnumerable<TViewModel> GetItems() => _items;

    public Dictionary<TKey, TViewModel> ToDictionary<TKey>(Func<TViewModel, TKey> keySelector)
    {
      return _items.ToDictionary(keySelector);
    }

    public virtual IEnumerable<TModel> GetModels()
    {
      foreach (var viewModel in _items)
      {
        yield return ToModel(viewModel);
      }
    }

    public void ForEach(Action<TViewModel> action)
    {
      foreach (var model in _items)
      {
        action(model);
      }
    }

    protected abstract TModel ToModel(TViewModel viewModel);
    protected abstract TViewModel ToViewModel(TModel model);

    protected abstract TViewModel NewViewModel();

    protected override bool CanAdd() => true;

    protected override void DoAdd()
    {
      var item = NewViewModel();
      if (item != null)
      {
        _items.Add(item);
        SelectedItem = item;
      }
    }

    protected override bool CanRemove() => SelectedItem != null;

    protected override void DoRemove()
    {
      if (Messenger.Confirm("Are you sure you want to remove the selected item?", "Confirm"))
      {
        int index = _items.IndexOf(SelectedItem);
        _items.Remove(SelectedItem);
        index = Math.Min(index, _items.Count - 1);
        if (-1 < index && index < _items.Count)
        {
          SelectedItem = _items[index];
        }
      }
    }

    public TViewModel Find(string id)
      => _items.SingleOrDefault(i => string.Equals(i.Id, id));

    private void _items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
      CollectionChanged?.Invoke(sender, e);
    }
  }
}
