using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  [DataContract(Name = "Paycheck", Namespace = Program.Namespace)]
  public class Paycheck : RecurringPayment
  {
    [DataMember(Order = 0)]
    public string Description { get; set; }
  }
}
