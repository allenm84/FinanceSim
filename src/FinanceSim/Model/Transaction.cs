namespace FinanceSim
{
  public class Transaction : IHasDueInfo
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public DueInfo Due { get; set; }
    public string FromId { get; set; }
    public string ToId { get; set; }
    public decimal Amount { get; set; }
  }
}
