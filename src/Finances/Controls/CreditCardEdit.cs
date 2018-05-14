using DevExpress.XtraEditors;

namespace Finances
{
  public partial class CreditCardEdit : XtraUserControl, IEditControl
  {
    private CreditCard _creditCard;

    public CreditCardEdit()
    {
      InitializeComponent();
    }

    object IEditControl.Source
    {
      get => _creditCard;
      set
      {
        if (value is CreditCard creditCard)
        {
          _creditCard = creditCard;
          ctrlLoanEdit.Loan = _creditCard;
          ctrlPayments.Setup<RecurringPayment, RecurringPaymentEdit>(_creditCard.Payments);
        }
      }
    }
  }
}
