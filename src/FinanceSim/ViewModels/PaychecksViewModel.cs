using System.Collections.Generic;

namespace FinanceSim
{
  public class PaychecksViewModel : CollectionEditorViewModel<PaycheckItemViewModel, Paycheck>
  {
    public PaychecksViewModel(ProfileViewModel profile, List<Paycheck> paychecks) 
      : base(profile, paychecks)
    {
    }

    protected override Paycheck ToModel(PaycheckItemViewModel viewModel)
    {
      return viewModel.GetModel();
    }

    protected override PaycheckItemViewModel ToViewModel(Paycheck model)
    {
      return new PaycheckItemViewModel(Profile, model);
    }

    protected override PaycheckItemViewModel NewViewModel()
    {
      return new PaycheckItemViewModel(Profile);
    }
  }
}