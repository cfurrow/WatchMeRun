using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;

namespace WatchMeRun.Library
{
  public class ConfigLoader
  {
    public static WatchMeRunSection Load()
    {
      using(StreamReader sr = new StreamReader(File.OpenRead("config.yml")))
      {
      }
    }
  }
}
