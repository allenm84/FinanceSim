using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class Profile : BaseNamedItem
  {
    public DateTime Created { get; set; } = DateTime.Today;
    public decimal StartingBalance { get; set; }
    public DateTime StartDate { get; set; }
    public int Years { get; set; }
    public List<CreditCard> CreditCards { get; set; } = new List<CreditCard>();
    public List<Loan> Loans { get; set; } = new List<Loan>();
    public List<Paycheck> Paychecks { get; set; } = new List<Paycheck>();
    public List<RecurringPayment> RecurringPayments { get; set; } = new List<RecurringPayment>();
  }
}
