using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class Loan : Paycheck
  {
    public InterestRate InterestRate { get; set; } = new InterestRate();
    public decimal Balance { get; set; }
  }
}
