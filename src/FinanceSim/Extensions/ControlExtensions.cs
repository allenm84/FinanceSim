using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace FinanceSim
{
  public static class ControlExtensions
  {
    public static void ProcessDeleteKey(this ColumnView grid, KeyEventArgs e, IWin32Window window, 
      string message = "Are you sure you want to delete the selected rows?", 
      string caption = "Confirm")
    {
      if (e.KeyCode == Keys.Delete && window.Confirm(message, caption))
      {
        grid.DeleteSelectedRows();
      }
    }

    public static bool Confirm(this IWin32Window window, string message, string caption = "Confirm")
    {
      var result = XtraMessageBox.Show(window, message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      return (result == DialogResult.Yes);
    }

    public static void Error(this IWin32Window window, string message, string caption = "Error")
    {
      XtraMessageBox.Show(window, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
  }
}
