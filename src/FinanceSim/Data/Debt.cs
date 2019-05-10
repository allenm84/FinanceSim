using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class Debt : Bill, IAccount
  {
    private decimal _interest;
    private decimal _balance;

    public decimal Interest
    {
      get => _interest;
      set => SetField(ref _interest, value);
    }

    public decimal Balance
    {
      get => _balance;
      set => SetField(ref _balance, value);
    }
  }
}
