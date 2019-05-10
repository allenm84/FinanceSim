using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class BankAccount : BaseNotifyPropertyChanged, IAccount
  {
    private string _name;
    private BankAccountType _type;
    private decimal _balance;
    private decimal _apy;

    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string Name
    {
      get => _name;
      set => SetField(ref _name, value);
    }

    public BankAccountType Type
    {
      get => _type;
      set => SetField(ref _type, value);
    }

    public decimal Balance
    {
      get => _balance;
      set => SetField(ref _balance, value);
    }

    public decimal APY
    {
      get => _apy;
      set => SetField(ref _apy, value);
    }
  }
}
