namespace FinanceSim
{
  public abstract class BasePayment : IHasDueInfo
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public DueInfo Due { get; set; }
    public decimal Payment { get; set; }
    public string AccountId { get; set; }
  }
}
