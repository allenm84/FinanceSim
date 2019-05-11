using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class SimulationSnowballState : IAccount
  {
    private PropertyChangedEventHandler _propertyChanged;

    public decimal Amount { get; set; }
    public Debt Target { get; set; }
    public HashSet<string> PaidOff { get; } = new HashSet<string>();

    string IAccount.Name => "Snowball";

    decimal IAccount.Balance
    {
      get => Amount;
      set => Amount = value;
    }

    string IHasId.Id => "Snowball.Id";

    event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
    {
      add { _propertyChanged += value; }
      remove { _propertyChanged -= value; }
    }
  }
}
