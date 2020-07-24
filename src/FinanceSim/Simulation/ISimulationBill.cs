using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public interface ISimulationBill
  {
    string Id { get; }
    string Name { get; }
    decimal Payment { get; set; }
  }
}
