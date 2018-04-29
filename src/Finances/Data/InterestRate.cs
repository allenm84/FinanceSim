using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class InterestRate : IRecurringPayment
  {
    public decimal Value { get; set; }
    public RecurringPaymentKind Kind { get; set; }
    public DateTime NextDueDate { get; set; }
  }
}
