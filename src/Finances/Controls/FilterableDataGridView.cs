using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Windows.Forms
{
  public partial class FilterableDataGridView : UserControl
  {
    private DataTable dataTable;

    public FilterableDataGridView()
    {
      InitializeComponent();
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public DataTable DataTable
    {
      get { return dataTable; }
      set
      {
        dataTable = value;
        dataGridView1.DataSource = dataTable;
      }
    }

    private void txtFilter_TextChanged(object sender, EventArgs e)
    {
      string input = txtFilter.Text;
      if (string.IsNullOrWhiteSpace(input))
      {
        dataTable.DefaultView.RowFilter = string.Empty;
      }
      else
      {
        dataTable.DefaultView.RowFilter = string.Join(" or ", dataTable.Columns
          .OfType<DataColumn>()
          .Where(c => c.DataType == typeof(string))
          .Select(c => string.Format("({0} LIKE '%{1}%')", c.ColumnName, input)));
      }
    }
  }
}
