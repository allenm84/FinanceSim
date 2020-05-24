namespace FinanceSim
{
  public class DebtItemViewModel : BasePaymentModelViewModel<Debt>, IHasBalanceViewModel
  {
    private decimal _interest;
    private decimal _balance;

    public DebtItemViewModel(ProfileViewModel profile, Debt model)
      : base(profile, model)
    {
      Interest = model.Interest;
      Balance = model.Balance;
    }

    public DebtItemViewModel(ProfileViewModel profile)
      : base(profile)
    {
    }

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

    public override Debt GetModel()
    {
      return new Debt
      {
        AccountId = Account?.Id,
        Balance = Balance,
        Due = Due.GetModel(),
        Id = Id,
        Interest = Interest,
        Name = Name,
        Payment = Payment,
      };
    }
  }
}