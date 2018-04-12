using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  [DataContract(Name = "RecurringPayment", Namespace = Program.Namespace)]
  public class RecurringPayment : Bill, IRecurringPayment
  {
    [DataMember(Order = 0)]
    public RecurringPaymentKind Kind { get; set; }
    [DataMember(Order = 1)]
    public DateTime NextDueDate { get; set; }
  }
}
