using System.Collections.Generic;

namespace FinanceSim
{
  public class BillsViewModel : CollectionEditorViewModel<BillItemViewModel, Bill>
  {
    public BillsViewModel(ProfileViewModel profile, List<Bill> bills)
      : base(profile, bills)
    {
    }

    protected override Bill ToModel(BillItemViewModel viewModel)
    {
      return viewModel.GetModel();
    }

    protected override BillItemViewModel ToViewModel(Bill model)
    {
      return new BillItemViewModel(Profile, model);
    }

    protected override BillItemViewModel NewViewModel()
    {
      return new BillItemViewModel(Profile);
    }
  }
}