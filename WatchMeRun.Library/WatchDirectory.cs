using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WatchMeRun.Library
{
  public class WatchDirectory
  {
    public string Path { get; set; }
    public string Watch {get;set;}
    public string Run {get;set;}

    public DateTime FileModifiedDate {get;set;}

    public System.IO.FileInfo File
    {
      get
      {
        return new System.IO.FileInfo(Path+Watch);
      }
    }
  }
}
