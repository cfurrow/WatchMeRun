using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace WatchMeRun.Service
{
  public class WatchMeRunSection : ConfigurationSection
  {
    [ConfigurationProperty("directories")]
    public DirectoryElement Directories { get;set; }
  }

  public class DirectoryElement : ConfigurationElement
  {

  }
}
