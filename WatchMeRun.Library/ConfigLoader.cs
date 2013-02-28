using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using System.Dynamic;
using Toml;

namespace WatchMeRun.Library
{
  public class ConfigLoader
  {
    public static List<WatchDirectory> Load(string path)
    {
      dynamic td                       = File.ReadAllText(path).ParseAsToml();
      ExpandoObject eo                 = (ExpandoObject)td;
      List<WatchDirectory> directories = new List<WatchDirectory>();
      IDictionary<string,object> dict  = eo;
      WatchDirectory currentDirectory  = null;

      foreach (KeyValuePair<string, object> topLevel in dict["directories"] as IDictionary<string,object>)
      {
        Console.WriteLine(topLevel.Key + " " + topLevel.Value);
        currentDirectory = new WatchDirectory(); 
        foreach (KeyValuePair<string, object> dirInfo in topLevel.Value as IDictionary<string,object>)
        {
          Console.WriteLine(dirInfo.Key + " " + dirInfo.Value);
          if (dirInfo.Key == "path")
          {
            currentDirectory.Path = dirInfo.Value as string;
          }
          if (dirInfo.Key == "watch")
          {
            currentDirectory.Watch = dirInfo.Value as string;
          }
          if (dirInfo.Key == "run")
          {
            currentDirectory.Run = dirInfo.Value as string;
          }
        }
        directories.Add(currentDirectory);
        currentDirectory = null;
      }
      return directories;
    }
  }
}
