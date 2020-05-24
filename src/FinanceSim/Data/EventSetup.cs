using System.Collections.Generic;

namespace FinanceSim
{
  public class EventSetup
  {
    public List<ChangeBillPaymentEvent> ChangeBillPaymentEvents { get; set; } = new List<ChangeBillPaymentEvent>();
    public List<AdjustPaycheckTotalEvent> AdjustPaycheckTotalEvents { get; set; } = new List<AdjustPaycheckTotalEvent>();
    public List<AdjustSnowballAmountEvent> AdjustSnowballAmountEvents { get; set; } = new List<AdjustSnowballAmountEvent>();
  }
}
