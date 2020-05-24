using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
      return new TransactionItemViewModel(Profile, model);
    }

    protected override TransactionItemViewModel NewViewModel()
    {
      return new TransactionItemViewModel(Profile);
    }
  }
}
