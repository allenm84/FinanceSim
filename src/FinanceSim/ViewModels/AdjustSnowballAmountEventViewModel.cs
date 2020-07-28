namespace FinanceSim
{
  public class AdjustSnowballAmountEventViewModel : BaseEventViewModel
  {
    private decimal _amount;

    public AdjustSnowballAmountEventViewModel(ProfileViewModel profile, AdjustSnowballAmountEvent model)
      : base(profile, model)
    {
      Amount = model.Amount;
    }

    public AdjustSnowballAmountEventViewModel(ProfileViewModel profile)
      : base(profile)
    {

    }

    public decimal Amount
    {
      get => _amount;
      set => SetField(ref _amount, value);
    }

    public override BaseEvent GetModel()
    {
      return new AdjustSnowballAmountEvent
      {
        Amount = Amount,
        Date = Date,
        Name = Name,
      };
    }
  }
}