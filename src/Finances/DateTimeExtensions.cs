using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public static class DateTimeExtensions
  {
    public static bool Matches(this DateTime x, DateTime y)
    {
      return (x.Year == y.Year) && (x.Month == y.Month) && (x.Day == y.Day);
    }
  }
}
