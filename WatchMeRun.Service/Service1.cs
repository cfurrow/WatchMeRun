using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace WatchMeRun.Service
{
  public partial class Service1 : ServiceBase
  {
    public Service1()
    {
      InitializeComponent();
    }

    protected override void OnStart(string[] args)
    {
      WatchMeRunSection config = (WatchMeRunSection)System.Configuration.ConfigurationManager.GetSection( "watchMeRunGroup/watchMeRun");

      // load config file (directories, and files to watch, and commands to run)
    }

    protected override void OnStop()
    {
    }
  }
}
