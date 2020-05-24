using System;
using System.Linq;

namespace FinanceSim
{
  public class PaycheckItemViewModel : BaseIdViewModel
  {
    private BankAccountItemViewModel _account;
    private decimal _total;

    public PaycheckItemViewModel(ProfileViewModel profile, Paycheck model)
      : base(profile, model)
    {
      Total = model.Total;
      Account = Profile.FindAccount(model.AccountId);

      Due = new DueInfoViewModel(model.Due);
      Deposits = new PaycheckDepositsViewModel(profile, model.Deposits);
    }

    public PaycheckItemViewModel(ProfileViewModel profile)
      : base(profile)
    {
      Account = Profile.Accounts.First();

      Due = new DueInfoViewModel();
      Deposits = new PaycheckDepositsViewModel(profile);
    }

    public decimal Total
    {
      get => _total;
      set => SetField(ref _total, value);
    }

    public BankAccountItemViewModel Account
    {
      get => _account;
      set => SetField(ref _account, value);
    }

    public DueInfoViewModel Due { get; }

    public PaycheckDepositsViewModel Deposits { get; }

    public Paycheck GetModel()
    {
      return new Paycheck
      {
        AccountId = Account?.Id,
        Deposits = Deposits.GetModels().ToList(),
        Due = Due.GetModel(),
        Id = Id,
        Name = Name,
        Total = Total,
      };
    }
  }
}