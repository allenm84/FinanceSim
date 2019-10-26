using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class SimulationSetup
  {
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public bool UseSnowball { get; set; }
  }
}
