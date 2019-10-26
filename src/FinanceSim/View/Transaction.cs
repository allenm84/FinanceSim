using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class Transaction
  {
    public DateTime Date { get; set; }
    public string Name { get; set; }
    public decimal Amount { get; set; }
    public decimal Balance { get; set; }
  }
}
