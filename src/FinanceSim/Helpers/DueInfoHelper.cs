using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public static class DueInfoHelper
  {
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
