namespace FinanceSim
{
  public class PaymentsViewModel : BaseCollectionEditorAggregateViewModel<BasePaymentViewModel>
  {
    public PaymentsViewModel(BillsViewModel bills, DebtsViewModel debts) 
      : base(bills, debts)
    {
    }
  }
}