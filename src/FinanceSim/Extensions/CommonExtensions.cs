using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceSim
{
  public static class CommonExtensions
  {
    public static List<T> Ensure<T>(this List<T> list)
    {
      return list ?? new List<T>();
    }

    public static T Clone<T>(this T item) where T : class
    {
      if (item == null)
        return default;

      var data = JsonConvert.SerializeObject(item);
      return JsonConvert.DeserializeObject<T>(data);
    }

    public static IEnumerable<T> OfType<T>(this Profile profile)
    {
      foreach (var v in profile.Accounts.OfType<T>())
        yield return v;

      foreach (var v in profile.Bills.OfType<T>())
        yield return v;

      foreach (var v in profile.Debts.OfType<T>())
        yield return v;

      foreach (var v in profile.Paychecks.OfType<T>())
        yield return v;
    }

    public static void Set<T>(this BindingSource source, IEnumerable<T> items)
    {
      using (source.DeferListChangedEvents())
      {
        source.Clear();
        foreach (var item in items)
        {
          source.Add(item);
        }
      }
    }

    public static IDisposable DeferListChangedEvents(this BindingSource source)
    {
      source.RaiseListChangedEvents = false;
      return new RaiseListChangedEventsOnDispose(source);
    }

    private class RaiseListChangedEventsOnDispose : IDisposable
    {
      private BindingSource _source;

      public RaiseListChangedEventsOnDispose(BindingSource source)
      {
        _source = source;
      }

      void IDisposable.Dispose()
      {
        if (_source != null)
        {
          _source.RaiseListChangedEvents = true;
          _source.ResetBindings(false);
          _source = null;
        }
      }
    }
  }
}
