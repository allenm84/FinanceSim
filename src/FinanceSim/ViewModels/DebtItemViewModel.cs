﻿namespace FinanceSim
{
  public class DebtItemViewModel : BasePaymentModelViewModel<Debt>, IHasBalanceViewModel
  {
    private decimal _interest;
    private decimal _balance;
    private DebtType _type;

    public DebtItemViewModel(ProfileViewModel profile, Debt model)
      : base(profile, model)
    {
      Interest = model.Interest;
      Balance = model.Balance;
      Type = model.Type;
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

    public DebtType Type
    {
      get => _type;
      set => SetField(ref _type, value);
    }

    public override Debt GetModel()
    {
      return new()
      {
        AccountId = Account?.Id,
        Balance = Balance,
        Due = Due.GetModel(),
        Id = Id,
        Interest = Interest,
        Name = Name,
        Payment = Payment,
        Type = Type,
      };
    }
  }
}