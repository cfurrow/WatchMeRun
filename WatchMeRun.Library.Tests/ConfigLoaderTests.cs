using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MbUnit.Framework;

using WatchMeRun.Library;


namespace WatchMeRun.Library.Tests
{
  [TestFixture]
  public class ConfigLoaderTests
  {
    [Test]
    public void Test1()
    {
      dynamic config = ConfigLoader.Load("app.toml");

      Assert.IsNotNull(config);
      Assert.AreEqual(@"c:\directory",config.directories.test.path);
      Assert.AreEqual("watchme",config.directories.test.watch);
      Assert.AreEqual("runme.bat",config.directories.test.run);
    }
  }
}
