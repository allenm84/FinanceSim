using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class Transaction
  {
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public decimal Balance { get; set; }
  }
}
