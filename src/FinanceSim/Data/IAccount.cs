using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public interface IAccount : IHasId, INotifyPropertyChanged
  {
    string Name { get; }
    decimal Balance { get; set; }
  }
}
