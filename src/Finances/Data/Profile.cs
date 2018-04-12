using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  [DataContract(Name = "Profile", Namespace = Program.Namespace)]
  public class Profile : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public string Name { get; set; }
    [Browsable(false)]
    [DataMember(Order = 1)]
    public DateTime Created { get; set; }
    [DataMember(Order = 2)]
    public decimal StartingBalance { get; set; }
    [DataMember(Order = 3)]
    public DateTime StartDate { get; set; }
    [DataMember(Order = 4)]
    public int Years { get; set; }
    [DataMember(Order = 5)]
    public List<CreditCard> CreditCards { get; set; }
    [DataMember(Order = 6)]
    public List<Loan> Loans { get; set; }
    [DataMember(Order = 7)]
    public List<Paycheck> Paychecks { get; set; }
    [DataMember(Order = 8)]
    public List<RecurringPayment> RecurringPayments { get; set; }
  }
}
