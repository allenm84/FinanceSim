using System;

namespace FinanceSim
{
  public interface ISimulationItem
  {
    string Id { get; }
    string Name { get; }
  }
}
