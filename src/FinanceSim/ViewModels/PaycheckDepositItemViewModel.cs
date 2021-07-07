namespace FinanceSim
{
  public class PaycheckDepositItemViewModel : BaseIdViewModel
  {
    private BankAccountItemViewModel _account;
    private decimal _amount;

    public PaycheckDepositItemViewModel(ProfileViewModel profile, PaycheckDeposit model) 
      : base(profile, model)
    {
      Amount = model.Amount;
      Account = Profile.FindAccount(model.AccountId);
    }

    public PaycheckDepositItemViewModel(ProfileViewModel profile)
      : base(profile)
    {
      Account = Profile.Accounts.First();
    }

    public decimal Amount
    {
      get => _amount;
      set => SetField(ref _amount, value);
    }

    public BankAccountItemViewModel Account
    {
      get => _account;
      set => SetField(ref _account, value);
    }

    public PaycheckDeposit GetModel()
    {
      return new()
      {
        AccountId = Account?.Id,
        Amount = Amount,
        Name = Name,
      };
    }
  }
}