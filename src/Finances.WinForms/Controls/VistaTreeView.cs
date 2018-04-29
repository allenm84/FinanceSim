using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Forms
{
  public class VistaTreeView : TreeView
  {
    [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
    private extern static int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

    public VistaTreeView()
    {
      FullRowSelect = true;
      ShowLines = false;
      ShowRootLines = false;
    }

    protected override void OnHandleCreated(EventArgs e)
    {
      base.OnHandleCreated(e);
      if (!this.DesignMode && Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 6)
      {
        SetWindowTheme(this.Handle, "explorer", null);
      }
    }
  }
}
