using System.Collections.Generic;

namespace FinanceSim
{
  public class TransactionsViewModel : CollectionEditorViewModel<TransactionItemViewModel, Transaction>
  {
    public TransactionsViewModel(ProfileViewModel profile, IEnumerable<Transaction> items) 
      : base(profile, items)
    {
    }

    protected override Transaction ToModel(TransactionItemViewModel viewModel)
    {
      return viewModel.GetModel();
    }

    protected override TransactionItemViewModel ToViewModel(Transaction model)
    {
      return new(Profile, model);
    }

    protected override TransactionItemViewModel NewViewModel()
    {
      return new(Profile);
    }
  }
}
