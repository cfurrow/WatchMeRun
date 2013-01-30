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
      var config = ConfigLoader.Load();

      Assert.IsNotNull(config);
    }
  }
}
