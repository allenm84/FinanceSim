using System;

namespace FinanceSim
{
  public enum BaseEventType { AdjustPaycheckTotal, AdjustSnowballAmount, ChangePayment };

  public abstract class BaseEvent
  {
    public DateTime Date { get; set; }
    public abstract BaseEventType Type { get; }
  }
}
