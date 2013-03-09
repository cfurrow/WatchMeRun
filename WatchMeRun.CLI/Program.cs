using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WatchMeRun.Library;
using System.IO;
using System.Diagnostics;

namespace WatchMeRun.CLI
{
  class Program
  {
    static void Main(string[] args)
    {
      string path =  Directory.GetCurrentDirectory() + @"\app.toml";
      List<WatchDirectory> directories;
      Process process;
      string output = "";

      if (File.Exists(path))
      {
        Console.WriteLine("Found config");
        directories = ConfigLoader.Load(path);

        foreach (var dir in directories)
        { 
          dir.FileModifiedDate = dir.File.LastWriteTimeUtc;
        }

        Console.WriteLine("=========== Listening ===========");

        while (true)
        {
          foreach (var dir in directories)
          {
            if (dir.File.LastWriteTimeUtc > dir.FileModifiedDate)
            {
              dir.FileModifiedDate = dir.File.LastWriteTimeUtc;
              Console.WriteLine(string.Format("{0} modified. Running {1}{2}.",dir.Watch,dir.Path,dir.Run));
              // run command
              process = new Process();
              process.StartInfo.WorkingDirectory = dir.Path;
              process.StartInfo.FileName = dir.Path + dir.Run;
              process.StartInfo.UseShellExecute = false;
              process.StartInfo.RedirectStandardOutput = true;
              process.StartInfo.RedirectStandardError = true;

              process.Start();
              output = process.StandardOutput.ReadToEnd();
              Console.WriteLine(output);
              process.WaitForExit();
              Console.WriteLine(string.Format("=========== Done running '{0}' ===========",dir.Run));
            }
          }
          System.Threading.Thread.Sleep(1000);
        }
      }
      else
      {
        Console.WriteLine("No app.toml found");
      }
      Console.ReadLine();
    }
  }
}
