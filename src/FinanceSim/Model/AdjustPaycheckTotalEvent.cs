namespace FinanceSim
{
  public class AdjustPaycheckTotalEvent : BaseEvent
  {
    public string PaycheckId { get; set; }
    public decimal Amount { get; set; }
    public override BaseEventType Type => BaseEventType.AdjustPaycheckTotal;
  }
}
