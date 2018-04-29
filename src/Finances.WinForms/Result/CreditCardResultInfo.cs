using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class CreditCardResultInfo : LoanResultInfo
  {
    readonly CreditCard mCreditCard;

    public CreditCardResultInfo(CreditCard creditCard) : base(creditCard)
    {
      mCreditCard = creditCard;
    }

    public void AddTransaction(DateTime date, RecurringPayment transaction)
    {
      mCreditCard.Balance += transaction.Amount;
      AddResult(date, transaction.Name, -transaction.Amount);
    }
  }
}
