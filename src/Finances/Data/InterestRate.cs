using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  [DataContract(Name = "InterestRate", Namespace = Program.Namespace)]
  public class InterestRate : IRecurringPayment
  {
    [DataMember(Order = 0)]
    public decimal Value { get; set; }
    [DataMember(Order = 1)]
    public RecurringPaymentKind Kind { get; set; }
    [DataMember(Order = 2)]
    public DateTime NextDueDate { get; set; }

    public override string ToString()
    {
      return base.ToString();
    }
  }
}
