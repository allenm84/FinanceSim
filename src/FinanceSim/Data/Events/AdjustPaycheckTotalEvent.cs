using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class AdjustPaycheckTotalEvent
  {
    public DateTime Date { get; set; }
    public string PaycheckId { get; set; }
    public decimal Amount { get; set; }
  }
}
