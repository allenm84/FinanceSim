using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace FinanceSim
{
  public class ObservableCollectionEx<T> : ObservableCollection<T>
  {
    private bool _notificationSuppressed;
    private bool _suppressNotification;

    public bool SuppressNotification
    {
      get => _suppressNotification;
      set
      {
        _suppressNotification = value;
        if (_suppressNotification || !_notificationSuppressed)
        {
          return;
        }

        OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        _notificationSuppressed = false;
      }
    }

    public void Set(IEnumerable<T> items)
    {
      SuppressNotification = true;

      Clear();
      foreach (var item in items)
      {
        Add(item);
      }

      SuppressNotification = false;
    }

    protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
    {
      if (SuppressNotification)
      {
        _notificationSuppressed = true;
        return;
      }

      base.OnCollectionChanged(e);
    }
  }
}
