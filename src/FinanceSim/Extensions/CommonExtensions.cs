using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

      foreach (var v in profile.Transactions.OfType<T>())
        yield return v;
    }
  }
}
