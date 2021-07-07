using System.Collections.Generic;

namespace FinanceSim
{
  public class DebtsViewModel : CollectionEditorViewModel<DebtItemViewModel, Debt>
  {
    public DebtsViewModel(ProfileViewModel profile, List<Debt> debts)
      : base(profile, debts)
    {
    }

    protected override Debt ToModel(DebtItemViewModel viewModel)
    {
      return viewModel.GetModel();
    }

    protected override DebtItemViewModel ToViewModel(Debt model)
    {
      return new(Profile, model);
    }

    protected override DebtItemViewModel NewViewModel()
    {
      return new(Profile);
    }
  }
}