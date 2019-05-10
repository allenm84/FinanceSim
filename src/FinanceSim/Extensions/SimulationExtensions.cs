using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public static class SimulationExtensions
  {
    public static bool IsDue(this IHasDueInfo due, DateTime date, SimulationState state)
    {
      return state.IsDue(date, due);
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
  }
}
