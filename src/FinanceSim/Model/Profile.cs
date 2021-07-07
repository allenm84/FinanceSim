using System;
using System.Collections.Generic;

namespace FinanceSim
{
  public class Profile : BaseNotifyPropertyChanged, IHasName
  {
    public string Id { get; set; }

    private string _name;
    public string Name
    {
      get => _name;
      set => SetField(ref _name, value);
    }

    public DateTime Created { get; set; }
    public List<BankAccount> Accounts { get; set; } = new();
    public List<Bill> Bills { get; set; } = new();
    public List<Debt> Debts { get; set; } = new();
    public List<Paycheck> Paychecks { get; set; } = new();
    public List<Transaction> Transactions { get; set; } = new();
    public SnowBallSetup Snowball { get; set; } = new();
    public List<BaseEvent> Events { get; set; } = new();
    public SimulationSetup Setup { get; set; }
  }
}
