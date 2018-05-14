using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Finances
{
  public static class CollectionExtensions
  {
    public static bool Confirm(this IWin32Window window, string message, string caption = "Confirm")
    {
      var result = XtraMessageBox.Show(window, message, caption, 
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      return (result == DialogResult.Yes);
    }
  }
}
