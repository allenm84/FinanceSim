namespace FinanceSim
{
  public abstract class BasePaymentModelViewModel<TModel> : BasePaymentViewModel
    where TModel : BasePayment
  {
    private BankAccountItemViewModel _account;

    public BasePaymentModelViewModel(ProfileViewModel profile, TModel model)
      : base(profile, model)
    {
      Account = Profile.FindAccount(model.AccountId);
    }

    public BasePaymentModelViewModel(ProfileViewModel profile) 
      : base(profile)
    {
      Account = Profile.Accounts.First();
    }

    public BankAccountItemViewModel Account
    {
      get => _account;
      set => SetField(ref _account, value);
    }

    public abstract TModel GetModel();
  }
}
