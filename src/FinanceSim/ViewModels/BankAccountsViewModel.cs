using System.Collections.Generic;

namespace FinanceSim
{
  public class BankAccountsViewModel : CollectionEditorViewModel<BankAccountItemViewModel, BankAccount>
  {
    public BankAccountsViewModel(ProfileViewModel profile, List<BankAccount> accounts) 
      : base(profile, accounts)
    {
    }

    protected override BankAccount ToModel(BankAccountItemViewModel viewModel)
    {
      return viewModel.GetModel();
    }

    protected override BankAccountItemViewModel ToViewModel(BankAccount model)
    {
      return new BankAccountItemViewModel(Profile, model);
    }

    protected override BankAccountItemViewModel NewViewModel()
    {
      return new BankAccountItemViewModel(Profile);
    }
  }
}
