using System;
using Newtonsoft.Json;

namespace FinanceSim
{
  public static class CommonExtensions
  {
    public static bool IsEndOfMonth(this DateTime date)
    {
      var nextMonth = date.AddMonths(1);
      var firstOfNextMonth = new DateTime(nextMonth.Year, nextMonth.Month, 1);
      var endOfMonth = firstOfNextMonth.AddDays(-1).Date;
      return endOfMonth == date.Date;
    }

    public static T Clone<T>(this T item) where T : class
    {
      if (item == null)
        return default;

      var data = JsonConvert.SerializeObject(item, JsonConsts.Settings);
      return JsonConvert.DeserializeObject<T>(data, JsonConsts.Settings);
    }
  }
}
