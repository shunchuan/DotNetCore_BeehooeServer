using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetCore_BeehooeServer.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateTime dt=DateTime.Now;
            var tick = dt.Ticks;
        }
    }
}
