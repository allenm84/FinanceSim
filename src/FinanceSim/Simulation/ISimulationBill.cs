namespace FinanceSim
{
  public interface ISimulationBill
  {
    string Id { get; }
    string Name { get; }
    decimal Payment { get; set; }
  }
}
