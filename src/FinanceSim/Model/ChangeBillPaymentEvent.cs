namespace FinanceSim
{
  public class ChangeBillPaymentEvent : BaseEvent
  {
    public string BillId { get; set; }
    public decimal NewPayment { get; set; }
    public override BaseEventType Type => BaseEventType.ChangePayment;
  }
}
