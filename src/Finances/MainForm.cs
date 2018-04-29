using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Finances
{
  public partial class MainForm : BaseForm
  {
    private readonly object _saveLock = new object();

    private readonly string _filepath;
    private readonly List<Profile> _profiles;

    public MainForm()
    {
      InitializeComponent();
      _filepath = GetFilepath();
      _profiles = LoadProfiles(_filepath);
      ctrlProfiles.Setup<Profile, ProfileEdit>(_profiles);
    }

    private string GetFilepath()
    {
      var dir = Path.Combine(DropboxPath.Data, "Finances");
      if (!Directory.Exists(dir))
      {
        Directory.CreateDirectory(dir);
      }
      return Path.Combine(dir, "profiles.json");
    }

    private List<Profile> LoadProfiles(string filepath)
    {
      if (File.Exists(filepath))
      {
        var json = File.ReadAllText(filepath);
        return JsonConvert.DeserializeObject<List<Profile>>(json);
      }
      else
      {
        return new List<Profile>();
      }
    }

    private void SaveProfiles()
    {
      lock (_saveLock)
      {
        var json = JsonConvert.SerializeObject(_profiles);
        File.WriteAllText(_filepath, json);
      }
    }

    private void ctrlProfiles_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        var info = ctrlProfiles.HitTest(e.X, e.Y);
        if (info.InRowCell && ctrlProfiles.GetItem(info.RowHandle) is Profile profile)
        {
          var json = JsonConvert.SerializeObject(profile);
          var copy = JsonConvert.DeserializeObject<Profile>(json);
          var result = SimEngine.Run(copy);
          var dlg = new SimEngineResultDialog(result);
          dlg.Show(this);
        }
      }
    }

    private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      SaveProfiles();
    }
  }
}
