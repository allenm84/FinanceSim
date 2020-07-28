namespace FinanceSim
{
  public abstract class BasePaymentModelViewModel<TModel> : BasePaymentViewModel
    where TModel : BasePayment
  {
    private TModel _model;
    private IHasBalanceViewModel _account;

    public BasePaymentModelViewModel(ProfileViewModel profile, TModel model)
      : base(profile, model)
    {
      _model = model;
    }

    public BasePaymentModelViewModel(ProfileViewModel profile) 
      : base(profile)
    {
      Account = Profile.HasBalanceAccounts.First();
    }

    public IHasBalanceViewModel Account
    {
      get => _account;
      set => SetField(ref _account, value);
    }

    public abstract TModel GetModel();

    public virtual void CompleteInitialization()
    {
      Account = Profile.FindHasBalanceAccount(_model.AccountId);
    }
  }
}
