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
    public static void nop(this object obj) { }

    public static bool IsEndOfMonth(this DateTime date)
    {
      var days = DateTime.DaysInMonth(date.Year, date.Month);
      return date.Day == days;
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
