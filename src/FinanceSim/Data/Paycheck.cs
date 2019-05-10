using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class Paycheck : BaseNotifyPropertyChanged, IHasDueInfo
  {
    private string _accountId;
    private string _name;
    private decimal _total;
    private DueInfo _due;

    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string AccountId
    {
      get => _accountId;
      set => SetField(ref _accountId, value);
    }

    public string Name
    {
      get => _name;
      set => SetField(ref _name, value);
    }

    public decimal Total
    {
      get => _total;
      set => SetField(ref _total, value);
    }

    public DueInfo Due
    {
      get => _due;
      set => SetField(ref _due, value);
    }

    public List<PaycheckDeposit> Deposits { get; set; } = new List<PaycheckDeposit>();
  }
}
