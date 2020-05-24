namespace FinanceSim
{
  public class TransactionItemViewModel : BaseIdViewModel
  {
    private decimal _amount;
    private IHasBalanceViewModel _fromAccount;
    private IHasBalanceViewModel _toAccount;

    public TransactionItemViewModel(ProfileViewModel profile, Transaction model)
      : base(profile, model)
    {
      Amount = model.Amount;
      FromAccount = Profile.FindHasBalanceAccount(model.FromId);
      ToAccount = Profile.FindHasBalanceAccount(model.ToId);

      Due = new DueInfoViewModel(model.Due);
    }

    public TransactionItemViewModel(ProfileViewModel profile) 
      : base(profile)
    {
      FromAccount = Profile.HasBalanceAccounts.First();
      ToAccount = Profile.HasBalanceAccounts.First();
      Due = new DueInfoViewModel();
    }

    public decimal Amount
    {
      get => _amount;
      set => SetField(ref _amount, value);
    }

    public IHasBalanceViewModel FromAccount
    {
      get => _fromAccount;
      set => SetField(ref _fromAccount, value);
    }

    public IHasBalanceViewModel ToAccount
    {
      get => _toAccount;
      set => SetField(ref _toAccount, value);
    }

    public DueInfoViewModel Due { get; }

    public Transaction GetModel()
    {
      return new Transaction
      {
        Amount = Amount,
        Due = Due.GetModel(),
        FromId = FromAccount?.Id,
        Id = Id,
        Name = Name,
        ToId = ToAccount?.Id,
      };
    }
  }
}