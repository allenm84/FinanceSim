using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class PaycheckDeposit : BaseNotifyPropertyChanged
  {
    private string _accountId;
    private string _name;
    private decimal _amount;

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

    public decimal Amount
    {
      get => _amount;
      set => SetField(ref _amount, value);
    }
  }
}
