using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finances
{
  public partial class ProfileRunnerDialog : BaseForm
  {
    public ProfileRunnerDialog(Profile profile)
    {
      InitializeComponent();
      Run(profile);
    }

    private void SetIsWorking(bool working)
    {
      progStatus.Visible = working;
      tableLayoutPanel1.Enabled = !working;
    }

    private void Advance(IRecurringPayment item)
    {
      var date = item.NextDueDate;
      switch (item.Kind)
      {
        case RecurringPaymentKind.Biweekly:
          item.NextDueDate = date.AddDays(14);
          break;
        case RecurringPaymentKind.Monthly:
          item.NextDueDate = date.AddMonths(1);
          break;
        case RecurringPaymentKind.Once:
          item.NextDueDate = date;
          break;
        case RecurringPaymentKind.Yearly:
          item.NextDueDate = date.AddYears(1);
          break;
      }
    }

    private IEnumerable<RecurringPayment> EnumerateRecurringItems(Profile profile)
    {
      foreach (var paycheck in profile.Paychecks)
      {
        yield return paycheck;
      }

      foreach (var cc in profile.CreditCards)
      {
        yield return cc;

        foreach (var child in cc.Payments)
        {
          yield return child;
        }
      }

      foreach (var loan in profile.Loans)
      {
        yield return loan;
      }

      foreach (var bill in profile.RecurringPayments)
      {
        yield return bill;
      }
    }

    private TabPage CreateTabPage(DataTable table)
    {
      var page = new TabPage(table.TableName);
      var grid = new FilterableDataGridView();
      grid.DataTable = table;
      grid.Dock = DockStyle.Fill;
      page.Controls.Add(grid);
      return page;
    }

    private static void AddOverall(DataTable table, string name, DateTime date, Money amount, Money balance)
    {
      table.Rows.Add(name, date, amount, balance);
    }

    private (DataTable, Dictionary<CreditCard, CreditCardResultInfo>, Dictionary<Loan, LoanResultInfo>) RunWork(Profile profile)
    {
      DateTime i = profile.StartDate.Date;
      DateTime end = i.AddYears(profile.Years);

      var overall = new DataTable("Results");
      overall.Columns.Add("Name", typeof(string));
      overall.Columns.Add("Date", typeof(DateTime));
      overall.Columns.Add("Amount", typeof(Money));
      overall.Columns.Add("Balance", typeof(Money));

      var ccInfoItems = new Dictionary<CreditCard, CreditCardResultInfo>();
      var loanInfoItems = new Dictionary<Loan, LoanResultInfo>();

      var items = EnumerateRecurringItems(profile);
      foreach (var item in items)
      {
        if (item.Kind == RecurringPaymentKind.Once)
        {
          // skip this item if it is only due once
          continue;
        }

        while (item.NextDueDate < i)
        {
          Advance(item);
        }
      }

      decimal balance = profile.StartingBalance;
      for (; i <= end; i = i.AddDays(1))
      {
        foreach (var paycheck in profile.Paychecks)
        {
          if (paycheck.NextDueDate.Matches(i))
          {
            Advance(paycheck);
            balance += paycheck.Amount;
            AddOverall(overall, paycheck.Name, i, paycheck.Amount, balance);
          }
        }

        foreach (var cc in profile.CreditCards)
        {
          if (!ccInfoItems.TryGetValue(cc, out CreditCardResultInfo info))
          {
            info = new CreditCardResultInfo(cc);
            ccInfoItems[cc] = info;
          }

          foreach (var item in cc.Payments)
          {
            if (item.NextDueDate.Matches(i))
            {
              Advance(item);
              info.AddTransaction(i, item);
            }
          }

          if (cc.NextDueDate.Matches(i))
          {
            Advance(cc);
            var actualPayment = info.MakePayment(i);

            balance -= actualPayment;
            AddOverall(overall, cc.Name, i, -actualPayment, balance);
          }
        }

        foreach (var loan in profile.Loans.Where(l => l.Balance > 0))
        {
          if (!loanInfoItems.TryGetValue(loan, out LoanResultInfo info))
          {
            info = new LoanResultInfo(loan);
            loanInfoItems[loan] = info;
          }

          if (loan.NextDueDate.Matches(i))
          {
            Advance(loan);
            var actualPayment = info.MakePayment(i);

            balance -= actualPayment;
            AddOverall(overall, loan.Name, i, -actualPayment, balance);
          }
        }

        foreach (var bill in profile.RecurringPayments)
        {
          if (bill.NextDueDate.Matches(i))
          {
            Advance(bill);
            balance -= bill.Amount;
            AddOverall(overall, bill.Name, i, -bill.Amount, balance);
          }
        }
      }

      return (overall, ccInfoItems, loanInfoItems);
    }

    private async void Run(Profile profile)
    {
      SetIsWorking(true);
      (var overall, var ccInfoItems, var loanInfoItems) = await Task.Run(() => RunWork(profile));

      tabControl1.TabPages.Add(CreateTabPage(overall));

      foreach (var cckvp in ccInfoItems)
      {
        var value = cckvp.Value;
        tabControl1.TabPages.Add(CreateTabPage(value.Payments));
        tabControl1.TabPages.Add(CreateTabPage(value.Results));
      }

      foreach (var lkvp in loanInfoItems)
      {
        var value = lkvp.Value;
        tabControl1.TabPages.Add(CreateTabPage(value.Payments));
        tabControl1.TabPages.Add(CreateTabPage(value.Results));
      }

      SetIsWorking(false);
    }
  }
}
