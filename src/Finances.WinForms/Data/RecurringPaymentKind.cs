using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  [DataContract(Name = "RecurringPaymentKind", Namespace = Program.Namespace)]
  public enum RecurringPaymentKind
  {
    [EnumMember]
    Monthly,
    [EnumMember]
    Yearly,
    [EnumMember]
    Biweekly,
    [EnumMember]
    Once,
  }
}
