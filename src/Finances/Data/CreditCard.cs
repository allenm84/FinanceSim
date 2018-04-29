using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class CreditCard : Loan
  {
    public List<RecurringPayment> Payments { get; set; } = new List<RecurringPayment>();
  }
}
