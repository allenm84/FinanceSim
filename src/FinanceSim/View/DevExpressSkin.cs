using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.LookAndFeel;

namespace FinanceSim
{
  public class DevExpressSkin : IDisposable
  {
    private readonly string mFilepath = "skin.dat";

    public DevExpressSkin()
    {
      var skin = UserLookAndFeel.DefaultSkinName;
      if (File.Exists(mFilepath))
      {
        skin = File.ReadAllText(mFilepath);
      }

      UserLookAndFeel.Default.SetSkinStyle(skin);
    }

    void IDisposable.Dispose()
    {
      File.WriteAllText(mFilepath, UserLookAndFeel.Default.SkinName);
    }
  }
}
