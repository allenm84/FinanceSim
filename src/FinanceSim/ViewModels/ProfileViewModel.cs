using System;
using System.Linq;

namespace FinanceSim
{
  public class ProfileViewModel : BaseNotifyPropertyChanged
  {
    private string _name;

    public ProfileViewModel(Profile model)
    {
      _name = model.Name;
      Created = model.Created;

      Accounts = new BankAccountsViewModel(this, model.Accounts);
      Bills = new BillsViewModel(this, model.Bills);
      Debts = new DebtsViewModel(this, model.Debts);
      Paychecks = new PaychecksViewModel(this, model.Paychecks);

      Payments = new PaymentsViewModel(Bills, Debts);
      HasBalanceAccounts = new HasBalanceAccountsViewModel(Accounts, Debts);

      Transactions = new TransactionsViewModel(this, model.Transactions);

      Snowball = new SnowBallSetupViewModel(this, model.Snowball);
      Events = new EventSetupViewModel(this, model.Events);

      Bills.ForEach(b => b.CompleteInitialization());
      Debts.ForEach(d => d.CompleteInitialization());

      Setup = new SimulationSetupViewModel(model.Setup);
    }

    public string Name
    {
      get => _name;
      set => SetField(ref _name, value);
    }

    public DateTime Created { get; }

    public BankAccountsViewModel Accounts { get; }
    public BillsViewModel Bills { get; }
    public DebtsViewModel Debts { get; }
    public PaychecksViewModel Paychecks { get; }
    public TransactionsViewModel Transactions { get; }

    public SnowBallSetupViewModel Snowball { get; }
    public EventSetupViewModel Events { get; }

    public PaymentsViewModel Payments { get; }
    public HasBalanceAccountsViewModel HasBalanceAccounts { get; }
    public SimulationSetupViewModel Setup { get; }

    public Profile GetModel()
    {
      return new Profile
      {
        Accounts = Accounts.GetModels().ToList(),
        Bills = Bills.GetModels().ToList(),
        Created = Created,
        Debts = Debts.GetModels().ToList(),
        Events = Events.GetModel(),
        Name = Name,
        Paychecks = Paychecks.GetModels().ToList(),
        Setup = Setup.GetModel(),
        Snowball = Snowball.GetModel(),
        Transactions = Transactions.GetModels().ToList(),
      };
    }

    public BankAccountItemViewModel FindAccount(string id) => 
      Accounts.Find(id);

    public BillItemViewModel FindBill(string id) => 
      Bills.Find(id);

    public DebtItemViewModel FindDebt(string id) => 
      Debts.Find(id);

    public PaycheckItemViewModel FindPaycheck(string id) => 
      Paychecks.Find(id);

    public BasePaymentViewModel FindBasePayment(string id) =>
      Payments.Find(id);

    public IHasBalanceViewModel FindHasBalanceAccount(string id) =>
      HasBalanceAccounts.Find(id);
  }
}
