using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;

namespace Finances
{
  public partial class RecurringPaymentKindEdit : DevExpress.XtraEditors.XtraUserControl
  {
    public RecurringPaymentKindEdit()
    {
      InitializeComponent();
      Populate();
      cboKind.EditValueChanged += cboKind_EditValueChanged;
    }

    public event EventHandler ValueChanged;

    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public RecurringPaymentKind Value
    {
      get
      {
        if (cboKind.EditValue is RecurringPaymentKind kind)
        {
          return kind;
        }
        return RecurringPaymentKind.Monthly;
      }
      set => cboKind.EditValue = value;
    }

    private void Populate()
    {
      var combo = cboKind.Properties;
      combo.NullText = "[Select Recurrment Type]";
      combo.DataSource = Enum
        .GetValues(typeof(RecurringPaymentKind))
        .Cast<RecurringPaymentKind>()
        .Select(t => new { Display = $"{t}", Value = t })
        .ToArray();
      combo.DisplayMember = "Display";
      combo.ValueMember = "Value";
      combo.ShowHeader = false;
      combo.Columns.Add(new LookUpColumnInfo
      {
        AllowSort = DefaultBoolean.True,
        FieldName = "Display",
        Caption = "Kind",
        SortOrder = ColumnSortOrder.Ascending,
        Visible = true,
      });
    }

    protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
    {
      height = cboKind.Height;
      base.SetBoundsCore(x, y, width, height, specified);
    }

    private void cboKind_EditValueChanged(object sender, EventArgs e)
    {
      ValueChanged?.Invoke(this, e);
    }
  }
}
