namespace FinanceSim
{
  public class AdjustSnowballAmountEvent : BaseEvent
  {
    public decimal Amount { get; set; }
    public override BaseEventType Type => BaseEventType.AdjustSnowballAmount;
  }
}
