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

namespace Finances
{
  public partial class TransactionGridView : DevExpress.XtraEditors.XtraUserControl
  {
    public TransactionGridView()
    {
      InitializeComponent();
    }

    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public object DataSource
    {
      get => transactionBindingSource.DataSource;
      set => transactionBindingSource.DataSource = value;
    }
  }
}
