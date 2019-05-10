using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace FinanceSim
{
  public partial class TransactionGridView : DevExpress.XtraEditors.XtraUserControl
  {
    public TransactionGridView()
    {
      InitializeComponent();
    }

    public TransactionGridView(IEnumerable<Transaction> transactions) : this()
    {
      transactionBindingSource.Set(transactions);
      Dock = DockStyle.Fill;
    }
  }
}
