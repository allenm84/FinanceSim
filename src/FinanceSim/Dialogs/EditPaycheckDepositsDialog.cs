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
using DevExpress.XtraEditors.Repository;

namespace FinanceSim
{
  public partial class EditPaycheckDepositsDialog : BaseForm
  {
    public EditPaycheckDepositsDialog()
    {
      InitializeComponent();
    }

    public IEnumerable<PaycheckDeposit> Deposits
    {
      get => paycheckDepositBindingSource.OfType<PaycheckDeposit>();
      set => paycheckDepositBindingSource.Set(value);
    }

    public RepositoryItem ColumnEdit
    {
      get => colAccountId.ColumnEdit;
      set => colAccountId.ColumnEdit = value;
    }

    private void gridDeposits_ProcessGridKey(object sender, KeyEventArgs e)
    {
      gridViewDeposits.ProcessDeleteKey(e, this);
    }
  }
}