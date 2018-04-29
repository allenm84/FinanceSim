using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public enum RecurringPaymentKind
  {
    Monthly,
    Weekly,
    Biweekly,
    Yearly,
    Once,
  }
}
