using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using TOML;

namespace WatchMeRun.Library
{
  public class ConfigLoader
  {
    public static dynamic Load(string path)
    {
      dynamic td;
      TomlParser.TryParse(File.ReadAllText(path),out td);
      return td;
    }
  }
}
