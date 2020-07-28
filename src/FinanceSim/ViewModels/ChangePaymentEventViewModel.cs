namespace FinanceSim
{
  public class ChangePaymentEventViewModel : BaseEventViewModel
  {
    private BasePaymentViewModel _target;
    private decimal _newPayment;

    public ChangePaymentEventViewModel(ProfileViewModel profile, ChangeBillPaymentEvent model)
      : base(profile, model)
    {
      NewPayment = model.NewPayment;
      Target = Profile.FindBasePayment(model.BillId);
    }

    public ChangePaymentEventViewModel(ProfileViewModel profile)
      : base(profile)
    {
      Target = Profile.Payments.First();
    }

    public decimal NewPayment
    {
      get => _newPayment;
      set => SetField(ref _newPayment, value);
    }

    public BasePaymentViewModel Target
    {
      get => _target;
      set => SetField(ref _target, value);
    }

    public override BaseEvent GetModel()
    {
      return new ChangeBillPaymentEvent
      {
        Date = Date,
        Name = Name,
        BillId = Target?.Id,
        NewPayment = NewPayment,
      };
    }
  }
}