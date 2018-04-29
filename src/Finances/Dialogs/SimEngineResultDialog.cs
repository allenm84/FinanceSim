using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Finances
{
  public partial class SimEngineResultDialog : BaseForm
  {
    public SimEngineResultDialog(SimEngineResult result)
    {
      InitializeComponent();
      transactionGridView1.DataSource = result.Transactions;
      foreach (var kvp in result.LoanTransactions)
      {
        AddTab(kvp.Key.Name, kvp.Value.Transactions);
      }
    }

    private void AddTab(string name, List<Transaction> transactions)
    {
      var page = xtraTabControl1.TabPages.Add(name);
      page.SuspendLayout();

      var grid = new TransactionGridView();
      grid.Dock = DockStyle.Fill;
      grid.DataSource = transactions;
      page.Controls.Add(grid);

      page.ResumeLayout(false);
    }
  }
}