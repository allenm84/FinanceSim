using System.Collections.Generic;
using System.Linq;

namespace FinanceSim
{
  public class PaycheckDepositsViewModel : CollectionEditorViewModel<PaycheckDepositItemViewModel, PaycheckDeposit>
  {
    public PaycheckDepositsViewModel(ProfileViewModel profile)
      : this(profile, Enumerable.Empty<PaycheckDeposit>())
    {
    }

    public PaycheckDepositsViewModel(ProfileViewModel profile, IEnumerable<PaycheckDeposit> deposits)
      : base(profile, deposits)
    {
    }

    protected override PaycheckDeposit ToModel(PaycheckDepositItemViewModel viewModel)
    {
      return viewModel.GetModel();
    }

    protected override PaycheckDepositItemViewModel ToViewModel(PaycheckDeposit model)
    {
      return new(Profile, model);
    }

    protected override PaycheckDepositItemViewModel NewViewModel()
    {
      return new(Profile);
    }
  }
}