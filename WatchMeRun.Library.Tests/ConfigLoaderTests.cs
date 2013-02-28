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
      var dirs = ConfigLoader.Load("app.toml");
      Assert.IsNotNull(dirs);
      WatchDirectory dir = dirs.First();

      Assert.AreEqual(@"c:\directory",dir.Path);
      Assert.AreEqual("watchme",dir.Watch);
      Assert.AreEqual("runme.bat",dir.Run);

      dir = dirs.ElementAt(1);
      Assert.AreEqual(@"c:\directory2", dir.Path);
      Assert.AreEqual("build", dir.Watch);
      Assert.AreEqual("build.bat", dir.Run);
    }
  }
}
