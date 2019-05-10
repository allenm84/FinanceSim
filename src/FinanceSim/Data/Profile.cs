using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class Profile : BaseNotifyPropertyChanged
  {
    private string _name;
    public string Name
    {
      get => _name;
      set => SetField(ref _name, value);
    }

    public DateTime Created { get; set; }
    public List<BankAccount> Accounts { get; set; } = new List<BankAccount>();
    public List<Bill> Bills { get; set; } = new List<Bill>();
    public List<Debt> Debts { get; set; } = new List<Debt>();
    public List<Paycheck> Paychecks { get; set; } = new List<Paycheck>();
  }
}
