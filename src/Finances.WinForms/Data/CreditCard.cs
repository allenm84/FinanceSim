using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  [DataContract(Name = "CreditCard", Namespace = Program.Namespace)]
  public class CreditCard : Loan
  {
    [DataMember(Order = 0)]
    public List<RecurringPayment> Payments { get; set; } = new List<RecurringPayment>();
  }
}
