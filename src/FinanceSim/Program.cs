using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.Utils;

namespace FinanceSim
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      BonusSkins.Register();
      SkinManager.EnableFormSkins();

      using (new DevExpressSkin())
      using (var form = new MainForm())
      {
        AppearanceObject.DefaultFont = new System.Drawing.Font("Segoe UI", 10.5f);
        Application.Run(form);
      }
    }
  }
}
