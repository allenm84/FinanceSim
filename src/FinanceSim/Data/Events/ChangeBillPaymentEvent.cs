using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class ChangeBillPaymentEvent
  {
    public DateTime Date { get; set; }
    public string BillId { get; set; }
    public decimal NewPayment { get; set; }
  }
}
