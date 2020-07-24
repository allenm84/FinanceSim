namespace FinanceSim
{
  public abstract class BasePaymentViewModel : BaseIdViewModel
  {
    private decimal _payment;

    public BasePaymentViewModel(ProfileViewModel profile, BasePayment model)
      : base(profile, model)
    {
      Due = new DueInfoViewModel(model.Due);
      Payment = model.Payment;
    }

    public BasePaymentViewModel(ProfileViewModel profile) 
      : base(profile)
    {
      Due = new DueInfoViewModel();
    }

    public DueInfoViewModel Due { get; }

    public decimal Payment
    {
      get => _payment;
      set => SetField(ref _payment, value);
    }
  }
}
