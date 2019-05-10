using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class Bill : BaseNotifyPropertyChanged, IHasDueInfo
  {
    private string _name;
    private DueInfo _due;
    private decimal _payment;
    private string _accountId;

    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string Name
    {
      get => _name;
      set => SetField(ref _name, value);
    }

    public DueInfo Due
    {
      get => _due;
      set => SetField(ref _due, value);
    }

    public decimal Payment
    {
      get => _payment;
      set => SetField(ref _payment, value);
    }

    public string AccountId
    {
      get => _accountId;
      set => SetField(ref _accountId, value);
    }
  }
}
