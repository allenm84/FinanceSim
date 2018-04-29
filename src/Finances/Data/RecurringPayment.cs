using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class RecurringPayment : BaseItem, IRecurringPayment
  {
    public RecurringPaymentKind Kind { get; set; }
    public DateTime NextDueDate { get; set; }
  }
}
