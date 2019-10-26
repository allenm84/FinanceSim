using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class SnowBallSetup
  {
    public DateTime Start { get; set; }
    public decimal InitialAmount { get; set; }
    public string[] DebtOrder { get; set; }
  }
}
