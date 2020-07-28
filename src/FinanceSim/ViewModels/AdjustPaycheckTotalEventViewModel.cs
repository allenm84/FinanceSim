namespace FinanceSim
{
  public class AdjustPaycheckTotalEventViewModel : BaseEventViewModel
  {
    private decimal _amount;
    private PaycheckItemViewModel _paycheck;

    public AdjustPaycheckTotalEventViewModel(ProfileViewModel profile, AdjustPaycheckTotalEvent model)
      : base(profile, model)
    {
      Amount = model.Amount;
      Paycheck = Profile.FindPaycheck(model.PaycheckId);
    }

    public AdjustPaycheckTotalEventViewModel(ProfileViewModel profile)
      : base(profile)
    {
      Paycheck = Profile.Paychecks.First();
    }

    public decimal Amount
    {
      get => _amount;
      set => SetField(ref _amount, value);
    }

    public PaycheckItemViewModel Paycheck
    {
      get => _paycheck;
      set => SetField(ref _paycheck, value);
    }

    public override BaseEvent GetModel()
    {
      return new AdjustPaycheckTotalEvent
      {
        Amount = Amount,
        Date = Date,
        Name = Name,
        PaycheckId = Paycheck?.Id,
      };
    }
  }
}