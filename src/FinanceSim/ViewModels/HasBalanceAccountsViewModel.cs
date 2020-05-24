namespace FinanceSim
{
  public class HasBalanceAccountsViewModel : BaseCollectionEditorAggregateViewModel<IHasBalanceViewModel>
  {
    public HasBalanceAccountsViewModel(BankAccountsViewModel accounts, DebtsViewModel debts) 
      : base(accounts, debts)
    {
    }
  }
}