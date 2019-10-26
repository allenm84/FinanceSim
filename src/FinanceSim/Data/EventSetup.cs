using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class EventSetup
  {
    public List<ChangeBillPaymentEvent> ChangeBillPaymentEvents { get; set; }
    public List<AdjustPaycheckTotalEvent> AdjustPaycheckTotalEvents { get; set; }
    public List<AdjustSnowballAmountEvent> AdjustSnowballAmountEvents { get; set; }
  }
}
