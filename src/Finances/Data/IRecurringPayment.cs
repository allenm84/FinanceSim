using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public interface IRecurringPayment
  {
    RecurringPaymentKind Kind { get; set; }
    DateTime NextDueDate { get; set; }
  }
}
