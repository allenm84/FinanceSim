using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  [DataContract(Name = "Loan", Namespace = Program.Namespace)]
  public class Loan : RecurringPayment
  {
    [DataMember(Order = 0)]
    public decimal InterestRate { get; set; }
    [DataMember(Order = 1)]
    public decimal Balance { get; set; }
  }
}
