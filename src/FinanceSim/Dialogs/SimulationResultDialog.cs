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
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTab;

namespace FinanceSim
{
  public partial class SimulationResultDialog : BaseForm
  {
    public SimulationResultDialog()
    {
      InitializeComponent();
    }

    public void Populate(Dictionary<IAccount, List<Transaction>> result)
    {
      foreach (var kvp in result)
      {
        var account = kvp.Key;
        var page = xtraTabControl1.TabPages.Add(account.Name);
        page.SuspendLayout();
        page.Controls.Add(new TransactionGridView(kvp.Value));
        page.ResumeLayout(false);
      }
    }

    private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
    {
      if (e is ClosePageButtonEventArgs arg && arg.Page is XtraTabPage page)
      {
        page.PageVisible = false;
      }
    }
  }
}