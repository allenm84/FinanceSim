using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public static class DueInfoHelper
  {
    public static DateTime Sanitize(DateTime value, DueInfo due)
    {
      if (value.Day != due.Seed.Day)
      {
        int days = DateTime.DaysInMonth(value.Year, value.Month);
        value = new DateTime(value.Year, value.Month, Math.Min(days, due.Seed.Day));
      }
      return value;
    }

    public static DateTime Advance(DateTime date, DueInfo due)
    {
      switch (due.Type)
      {
        case DueType.Daily:
          // due every "N" days, from the seed
          date = date.AddDays(due.Period);
          break;
        case DueType.Weekly:
          // due every "N" weeks, from the seed
          date = date.AddDays(7 * due.Period);
          break;
        case DueType.Monthly:
          // due every "N" months from the seed
          date = Sanitize(date.AddMonths(due.Period), due);
          break;
        case DueType.Yearly:
          // due every "N" years from the seed
          date = Sanitize(date.AddYears(due.Period), due);
          break;
      }
      return date;
    }

    public static string GetDisplay(DueInfo due)
    {
      if (due.Type == DueType.Once)
      {
        return $"{due.Seed:d}";
      }
      else
      {
        return $"{due.Period}x {due.Type}, seed: {due.Seed:d}";
      }
    }
  }
}
