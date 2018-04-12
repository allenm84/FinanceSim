using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  [DataContract(Name = "Bill", Namespace = Program.Namespace)]
  public abstract class Bill : ExtensibleDataObject
  {
    public Bill()
    {
      Name = $"< New {GetType().Name} >";
    }

    [DataMember(Order = 0)]
    public string Name { get; set; }
    [DataMember(Order = 1)]
    public decimal Amount { get; set; }
  }
}
