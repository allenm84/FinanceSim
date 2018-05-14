using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public static class RecurringIncrementer
  {
    public static void Advance(this IRecurringPayment item)
    {
      var date = item.NextDueDate;
      switch (item.Kind)
      {
        case RecurringPaymentKind.Biweekly:
          item.NextDueDate = date.AddDays(14);
          break;
        case RecurringPaymentKind.Monthly:
          item.NextDueDate = date.AddMonths(1);
          break;
        case RecurringPaymentKind.Once:
          item.NextDueDate = date;
          break;
        case RecurringPaymentKind.Weekly:
          item.NextDueDate = date.AddDays(7);
          break;
        case RecurringPaymentKind.Yearly:
          item.NextDueDate = date.AddYears(1);
          break;
      }
    }
  }
}
