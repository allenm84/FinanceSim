namespace FinanceSim
{
  public class BillItemViewModel : BasePaymentModelViewModel<Bill>
  {
    public BillItemViewModel(ProfileViewModel profile, Bill model)
      : base(profile, model)
    {
    }

    public BillItemViewModel(ProfileViewModel profile)
      : base(profile)
    {
    }

    public override Bill GetModel()
    {
      return new()
      {
        AccountId = Account?.Id,
        Due = Due.GetModel(),
        Id = Id,
        Name = Name,
        Payment = Payment,
      };
    }
  }
}