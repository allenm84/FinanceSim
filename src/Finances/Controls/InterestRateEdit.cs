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
  public partial class InterestRateEdit : DevExpress.XtraEditors.XtraUserControl
  {
    public InterestRateEdit()
    {
      InitializeComponent();

      cboKind.ValueChanged += editControl_ValueChanged;
      dtNext.DateTimeChanged += editControl_ValueChanged;
      numPercentage.ValueChanged += editControl_ValueChanged;
    }

    public event EventHandler ValueChanged;

    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public InterestRate Value
    {
      get => new InterestRate
      {
        Kind = cboKind.Value,
        NextDueDate = dtNext.DateTime.Date,
        Value = numPercentage.Value,
      };
      set
      {
        cboKind.Value = value.Kind;
        dtNext.DateTime = value.NextDueDate;
        numPercentage.Value = value.Value;
      }
    }

    private void editControl_ValueChanged(object sender, EventArgs e)
    {
      ValueChanged?.Invoke(this, e);
    }
  }
}
