using System;

namespace FinanceSim
{
  public class SimulationTransaction
  {
    public DateTime Date { get; set; }
    public string Name { get; set; }
    public decimal Amount { get; set; }
    public decimal Balance { get; set; }
  }
}
