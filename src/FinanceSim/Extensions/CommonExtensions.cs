using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace FinanceSim
{
  public static class CommonExtensions
  {
    public static IEnumerable<BaseEvent> All(this EventSetup events)
    {
      foreach (var item in events.AdjustPaycheckTotalEvents)
      {
        yield return item;
      }

      foreach (var item in events.AdjustSnowballAmountEvents)
      {
        yield return item;
      }

      foreach (var item in events.ChangeBillPaymentEvents)
      {
        yield return item;
      }
    }

    public static bool IsEndOfMonth(this DateTime date)
    {
      var nextMonth = date.AddMonths(1);
      var firstOfNextMonth = new DateTime(nextMonth.Year, nextMonth.Month, 1);
      var endOfMonth = firstOfNextMonth.AddDays(-1).Date;
      return endOfMonth == date.Date;
    }

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

      foreach (var v in profile.Transactions.OfType<T>())
        yield return v;
    }
  }
}
