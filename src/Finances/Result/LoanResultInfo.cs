using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class LoanResultInfo
  {
    decimal new_balance;
    decimal interest_paid, annual_rate, principle_paid, payment;
    int count = 0;

    readonly Loan mLoan;
    readonly DataTable mResults;
    readonly DataTable mPayments;

    public LoanResultInfo(Loan loan)
    {
      mLoan = loan;

      mResults = new DataTable($"{loan.Name}Results");
      mResults.Columns.Add("Name", typeof(string));
      mResults.Columns.Add("Date", typeof(DateTime));
      mResults.Columns.Add("Amount", typeof(Money));
      mResults.Columns.Add("Balance", typeof(Money));

      mPayments = new DataTable($"{loan.Name}Payments");
      mPayments.Columns.Add("Count", typeof(int));
      mPayments.Columns.Add("Payment", typeof(Money));
      mPayments.Columns.Add("Interest", typeof(Money));
      mPayments.Columns.Add("Principle", typeof(Money));
      mPayments.Columns.Add("Balance", typeof(Money));

      annual_rate = loan.InterestRate / 100m;
      payment = loan.Amount;
    }

    public DataTable Results => mResults;
    public DataTable Payments => mPayments;

    protected void AddResult(DateTime date, string name, Money amount)
    {
      AddResult(date, name, amount, mLoan.Balance);
    }

    private void AddResult(DateTime date, string name, Money amount, Money balance)
    {
      mResults.Rows.Add(name, date, amount, balance);
    }

    public decimal MakePayment(DateTime date)
    {
      decimal actualPayment = 0;

      if (mLoan.Balance > 0)
      {
        new_balance = mLoan.Balance;

        // the payment should be the balance or the desired payment; whichever is smaller
        actualPayment = Math.Min(mLoan.Balance, payment);

        // Calculate interest by multiplying rate against balance
        interest_paid = new_balance * (annual_rate / 12m);

        // Subtract interest from your payment
        principle_paid = actualPayment - interest_paid;

        // Subtract final payment from running balance
        mLoan.Balance = new_balance - principle_paid;

        // don't let the balance get below zero
        mLoan.Balance = Math.Max(0, mLoan.Balance);

        // If the balance remaining plus its interest is less than payment amount
        // Then print out 0 balance, the interest paid and that balance minus the interest will tell us
        // how much principle you paid to get to zero.
        Report(count++, actualPayment, interest_paid, principle_paid, mLoan.Balance);

        // update the overall result table
        AddResult(date, $"Payment ({actualPayment:C2})", actualPayment - interest_paid);
      }

      return actualPayment;
    }

    private void Report(int count, Money payment, Money interest, Money principle, Money balance)
    {
      mPayments.Rows.Add(count, payment, interest, principle, balance);
    }
  }
}
