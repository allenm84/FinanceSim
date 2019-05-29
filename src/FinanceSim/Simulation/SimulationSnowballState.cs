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

    public SimulationSnowballState(decimal amount, SnowballDebtOrder order)
    {
      Amount = amount;
      Order = order;
    }

    public decimal Amount { get; set; }
    public SnowballDebtOrder Order { get; }
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
