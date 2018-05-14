using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class Paycheck : RecurringPayment
  {
    public string Description { get; set; }
  }
}
