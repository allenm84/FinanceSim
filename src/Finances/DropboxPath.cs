using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Finances
{
  public static class DropboxPath
  {
    public static string Value => ReadConfig();

    public static string Data => Path.Combine(Value, @"Apps\SharedAppData");

    private static string ReadConfig()
    {
      var locations = new[]
      {
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
      };

      foreach (var location in locations)
      {
        var filepath = Path.Combine(location, @"Dropbox\info.json");
        if (!File.Exists(filepath))
        {
          continue;
        }

        var value = JObject.Parse(File.ReadAllText(filepath));
        var path = value["personal"].Value<string>("path");
        return path;
      }

      throw new Exception(@"Dropbox\info.json not found.");
    }
  }
}
