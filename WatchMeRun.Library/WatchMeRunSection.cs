using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace WatchMeRun.Library
{
  public class WatchMeRunSection : ConfigurationSection
  {

    private static WatchMeRunSection sections = ConfigurationManager.GetSection("WatchMeRun") as WatchMeRunSection;
    public static WatchMeRunSection Sections
    {
      get
      {
        return sections;
      }
    }

    [ConfigurationProperty("path",IsRequired=true)]
    public string Path
    {
      get 
      {
        return (string)this["path"];
      }

      set
      {
        this["path"] = value;
      } 
    }

    [ConfigurationProperty("file",IsRequired=true)]
    public string File
    {

      get
      {
        return (string)this["file"];
      }

      set
      {
        this["file"] = value;
      }
    }

    [ConfigurationProperty("command",IsRequired=true)]
    public string Command
    {
      get
      {
        return (string)this["command"];
      }

      set
      {
        this["command"] = value;
      }
    }
  }
}
