using System;

namespace FinanceSim
{
  public enum BaseEventType { AdjustPaycheckTotal, AdjustSnowballAmount, ChangePayment };

  public abstract class BaseEvent
  {
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public abstract BaseEventType Type { get; }
  }
}
