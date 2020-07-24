using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace FinanceSim
{
  public class GitDrive
  {
    static readonly DirectoryInfo sWorkingDir;
    static GitDrive()
    {
      var parentDir = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

      sWorkingDir = new DirectoryInfo(Path.Combine(parentDir, ".gitDrive"));
      if (!sWorkingDir.Exists)
      {
        sWorkingDir.Create();
        sWorkingDir.Refresh();
      }
    }

    private readonly string _dirname;
    private readonly string _fullpath;
    private readonly string _key;

    public GitDrive(Uri cloneUrl)
    {
      CloneUrl = cloneUrl;

      _dirname = Path.GetFileNameWithoutExtension(CloneUrl.AbsolutePath);
      _fullpath = Path.Combine(sWorkingDir.FullName, _dirname);
      _key = Assembly.GetEntryAssembly().GetName().Name;
    }

    public Uri CloneUrl { get; }

    public async Task<bool> Initialize()
    {
      var result = true;

      if (!Directory.Exists(_fullpath))
      {
        result = await Task.Run(() => CloneGitDrive());
      }

      if (result)
      {
        var dirPath = Path.Combine(_fullpath, _key);
        if (!Directory.Exists(dirPath))
        {
          Directory.CreateDirectory(dirPath);
        }
      }

      return result;
    }

    private string GetFullPath(string path) => Path.Combine(_fullpath, _key, path);

    public bool FileExists(string path) => 
      File.Exists(GetFullPath(path));

    public bool DirectoryExists(string path) => 
      Directory.Exists(GetFullPath(path));

    public string ReadAllText(string path) => 
      File.ReadAllText(GetFullPath(path));

    public void WriteAllText(string path, string content)
    {
      File.WriteAllText(GetFullPath(path), content);
      git("add *");
      git($"commit -m \"WriteAllText @ {DateTime.Now}\"");
      git("push origin");
    }

    private (string stdout, string stderr) git(string args, string workingDir = null)
    {
      using (var git = new Process())
      {
        git.StartInfo.FileName = "git";
        git.StartInfo.Arguments = args;
        git.StartInfo.WorkingDirectory = (workingDir ?? _fullpath);
        git.StartInfo.UseShellExecute = false;
        git.StartInfo.RedirectStandardError = true;
        git.StartInfo.RedirectStandardOutput = true;
        git.StartInfo.CreateNoWindow = true;

        git.Start();

        var stdout = git.StandardOutput.ReadToEnd();
        var stderr = git.StandardError.ReadToEnd();

        git.WaitForExit();
        return (stdout, stderr);
      }
    }

    private bool CloneGitDrive()
    {
      try
      {
        git($"clone {CloneUrl} {_dirname}", sWorkingDir.FullName);
        return true;
      }
      catch
      {
        return false;
      }
    }
  }
}
