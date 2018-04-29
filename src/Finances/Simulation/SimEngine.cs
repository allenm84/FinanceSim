using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public static class SimEngine
  {
    public static IEnumerable<IRecurringPayment> RecurringItems(this Profile profile)
    {
      foreach (var paycheck in profile.Paychecks)
      {
        yield return paycheck;
      }

      foreach (var cc in profile.CreditCards)
      {
        yield return cc;
        yield return cc.InterestRate;

        foreach (var child in cc.Payments)
        {
          yield return child;
        }
      }

      foreach (var loan in profile.Loans)
      {
        yield return loan;
        yield return loan.InterestRate;
      }

      foreach (var bill in profile.RecurringPayments)
      {
        yield return bill;
      }
    }

    private static void MakeCurrent(DateTime start, Profile profile)
    {
      var items = profile.RecurringItems();
      foreach (var item in items)
      {
        if (item.Kind == RecurringPaymentKind.Once)
        {
          // skip this item if it is only due once
          continue;
        }

        while (item.NextDueDate < start)
        {
          item.Advance();
        }
      }
    }

    public static Transaction Add(this IList<Transaction> transactions, DateTime date, string name, decimal amount, decimal balance)
    {
      var t = new Transaction
      {
        Amount = amount,
        Balance = balance,
        Date = date,
        Name = name,
      };
      transactions.Add(t);
      return t;
    }

    private static void MakePayment(DateTime date, Loan loan, List<Transaction> transactions, LoanInfo info, ref decimal accountBalance)
    {
      // get the name
      var name = $"{loan.Name} PAYMENT({info.PaymentCount})";

      // move to the next due date
      loan.Advance();
      if (loan.Balance > 0)
      {
        // reduce the balance
        var payment = loan.Amount;
        var loanBalance = loan.Balance - payment;
        if (loanBalance < 0)
        {
          payment += loanBalance;
          loanBalance = 0;
        }
        loan.Balance = loanBalance;

        // add a payment
        ++info.PaymentCount;
        info.Transactions.Add(date, name, -payment, loanBalance);

        // add a withdrawal
        accountBalance -= payment;
        transactions.Add(date, name, -payment, accountBalance);
      }
    }

    private static void ApplyInterest(DateTime date, Loan loan, LoanInfo info)
    {
      // get the name
      var name = $"{loan.Name} INTEREST";

      // move to the next due date
      loan.InterestRate.Advance();

      // increase the balance
      var period = 1m;
      switch (loan.InterestRate.Kind)
      {
        case RecurringPaymentKind.Biweekly:
          period = 26m;
          break;
        case RecurringPaymentKind.Monthly:
          period = 12m;
          break;
        case RecurringPaymentKind.Weekly:
          period = 52m;
          break;
      }

      var rate = (loan.InterestRate.Value / 100m) / period;
      var amount = loan.Balance * rate;

      // add the interest charge
      loan.Balance += amount;
      info.Transactions.Add(date, name, amount, loan.Balance);
    }

    public static SimEngineResult Run(Profile profile)
    {
      var i = profile.StartDate.Date;
      var end = i.AddYears(profile.Years);
      MakeCurrent(i, profile);

      var transactions = new List<Transaction>();
      var loanTransactions = new Dictionary<Loan, LoanInfo>();

      var balance = profile.StartingBalance;
      for (; i <= end; i = i.AddDays(1))
      {
        foreach (var paycheck in profile.Paychecks)
        {
          if (paycheck.NextDueDate.Matches(i))
          {
            paycheck.Advance();
            balance += paycheck.Amount;
            transactions.Add(i, paycheck.Name, paycheck.Amount, balance);
          }
        }

        foreach (var cc in profile.CreditCards)
        {
          if (!loanTransactions.TryGetValue(cc, out LoanInfo info))
          {
            info = new LoanInfo();
            loanTransactions[cc] = info;
          }

          foreach (var item in cc.Payments)
          {
            if (item.NextDueDate.Matches(i))
            {
              cc.Balance += item.Amount;
              item.Advance();
              info.Transactions.Add(i, item.Name, item.Amount, cc.Balance);
            }
          }

          if (cc.NextDueDate.Matches(i))
          {
            MakePayment(i, cc, transactions, info, ref balance);
          }

          if (cc.InterestRate.NextDueDate.Matches(i))
          {
            ApplyInterest(i, cc, info);
          }
        }

        foreach (var loan in profile.Loans.Where(l => l.Balance > 0))
        {
          if (!loanTransactions.TryGetValue(loan, out LoanInfo info))
          {
            info = new LoanInfo();
            loanTransactions[loan] = info;
          }

          if (loan.NextDueDate.Matches(i))
          {
            MakePayment(i, loan, transactions, info, ref balance);
          }

          if (loan.InterestRate.NextDueDate.Matches(i))
          {
            ApplyInterest(i, loan, info);
          }
        }

        foreach (var bill in profile.RecurringPayments)
        {
          if (bill.NextDueDate.Matches(i))
          {
            bill.Advance();
            balance -= bill.Amount;
            transactions.Add(i, bill.Name, -bill.Amount, balance);
          }
        }
      }

      return new SimEngineResult
      {
        LoanTransactions = loanTransactions,
        Transactions = transactions,
      };
    }
  }
}
