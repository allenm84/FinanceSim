using System;

namespace FinanceSim
{
  public class HasBalanceAccountsViewModel : BaseCollectionEditorAggregateViewModel<IHasBalanceViewModel>
  {
    public HasBalanceAccountsViewModel(BankAccountsViewModel accounts, DebtsViewModel debts) 
      : base(accounts, debts)
    {
    }

    public override bool IsValid(IHasBalanceViewModel item)
    {
      if (item is DebtItemViewModel debt)
      {
        return debt.Type == DebtType.Revolving;
      }

      return true;
    }
  }
}