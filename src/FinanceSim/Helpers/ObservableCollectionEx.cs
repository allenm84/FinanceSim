using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace FinanceSim
{
  public class ObservableCollectionEx<T> : ObservableCollection<T>
  {
    private bool _notificationSupressed = false;
    private bool _supressNotification = false;
    public bool SupressNotification
    {
      get
      {
        return _supressNotification;
      }
      set
      {
        _supressNotification = value;
        if (_supressNotification == false && _notificationSupressed)
        {
          this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
          _notificationSupressed = false;
        }
      }
    }

    public void Set(IEnumerable<T> items)
    {
      SupressNotification = true;

      Clear();
      foreach (T item in items)
      {
        Add(item);
      }

      SupressNotification = false;
    }

    protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
    {
      if (SupressNotification)
      {
        _notificationSupressed = true;
        return;
      }
      base.OnCollectionChanged(e);
    }
  }
}
