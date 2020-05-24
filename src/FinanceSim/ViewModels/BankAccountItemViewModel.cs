namespace FinanceSim
{
  public class BankAccountItemViewModel : BaseIdViewModel, IHasBalanceViewModel
  {
    private BankAccountType _type;
    private decimal _balance;
    private decimal _apy;

    public BankAccountItemViewModel(ProfileViewModel profile, BankAccount model)
      : base(profile, model)
    {
      Type = model.Type;
      Balance = model.Balance;
      APY = model.APY;
    }

    public BankAccountItemViewModel(ProfileViewModel profile) 
      : base(profile)
    {
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

    public BankAccount GetModel()
    {
      return new BankAccount
      {
        APY = APY,
        Balance = Balance,
        Id = Id,
        Name = Name,
        Type = Type,
      };
    }
  }
}