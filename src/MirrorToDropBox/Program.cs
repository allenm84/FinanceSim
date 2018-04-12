using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirrorToDropBox
{
  class Program
  {
    static void Main(string[] args)
    {
      var source = args[0];
      Console.Out.WriteLine($"\t\tsrc: {source}");

      var destination = Path.Combine(DropboxPath.Value, args[1]);
      Console.Out.WriteLine($"\t\tdst: {destination}");

      var process = new Process();
      process.StartInfo.FileName = "robocopy";
      process.StartInfo.Arguments = $"\"{source}\" \"{destination}\" *.dll *.exe /MIR /E /XO /W:5 /R:10";
      process.StartInfo.UseShellExecute = false;
      process.StartInfo.CreateNoWindow = true;
      process.StartInfo.RedirectStandardError = true;
      process.StartInfo.RedirectStandardOutput = true;
      process.EnableRaisingEvents = false;
      process.OutputDataReceived += (s, e) => Console.Out.WriteLine(e.Data);
      process.ErrorDataReceived += (s, e) => Console.Error.WriteLine(e.Data);
      process.Start();
      process.BeginOutputReadLine();
      process.BeginErrorReadLine();
      process.WaitForExit();
    }
  }
}
