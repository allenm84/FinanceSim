using System.Collections.Generic;

namespace FinanceSim
{
  public class EventSetup
  {
    public List<ChangeBillPaymentEvent> ChangeBillPaymentEvents { get; set; }
    public List<AdjustPaycheckTotalEvent> AdjustPaycheckTotalEvents { get; set; }
    public List<AdjustSnowballAmountEvent> AdjustSnowballAmountEvents { get; set; }
  }
}
