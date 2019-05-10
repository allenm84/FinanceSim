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

namespace FinanceSim
{
  public partial class EditDueInfoDialog : BaseForm
  {
    public EditDueInfoDialog()
    {
      InitializeComponent();
      dtEnd.DataBindings.Add("Enabled", chkHasEnd, "Checked");

      numPeriod.Properties.MinValue = 0;
      numPeriod.Properties.MaxValue = int.MaxValue;

      var items = Enum
        .GetValues(typeof(DueType))
        .OfType<DueType>()
        .Select(t => new { Value = t, Display = $"{t}" })
        .ToArray();

      var properties = cboType.Properties;
      properties.DataSource = items;
      properties.DisplayMember = "Display";
      properties.ValueMember = "Value";
      properties.ShowHeader = false;
      properties.ShowLines = false;
      properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo
      {
        FieldName = "Display",
        SortOrder = DevExpress.Data.ColumnSortOrder.Ascending,
        Visible = true,
      });
    }

    public DueInfo Value
    {
      get => GetValue();
      set => ReadValue(value);
    }

    private DueInfo GetValue()
    {
      var info = new DueInfo();
      info.Start = dtStart.DateTime.Date;

      info.End = null;
      if (chkHasEnd.Checked)
      {
        info.End = dtEnd.DateTime.Date;
      }

      if (cboType.EditValue is DueType type)
      {
        info.Type = type;
      }

      info.Period = (int)numPeriod.Value;
      info.Seed = dtSeed.DateTime.Date;

      return info;
    }

    private void ReadValue(DueInfo value)
    {
      dtStart.DateTime = value.Start;
      if (value.End.HasValue)
      {
        chkHasEnd.Checked = true;
        dtEnd.DateTime = value.End.Value;
      }
      else
      {
        chkHasEnd.Checked = false;
        dtEnd.EditValue = DBNull.Value;
      }
      cboType.EditValue = value.Type;
      numPeriod.Value = value.Period;
      dtSeed.EditValue = value.Seed;
    }
  }
}