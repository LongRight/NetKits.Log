using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetKits.Log.Test
{
    [TestClass]
    public class Log4NetLogFactoryUnit
    {
        [TestMethod]
        public void TestLog()
        {
            ILogFactory factory = new Log4NetLogFactory();
            ILog log = factory.GetLog("unitTest");
            log.ErrorFormat("发生了错误:{0}", "我就开个玩笑");
        }

        [TestMethod]
        public void TestLogSuccess()
        {
            ILogFactory factory = new Log4NetLogFactory(false);
            ILog log = factory.GetLog("unitTest");
            log.ErrorFormat("发生了错误:{0}", "我就开个玩笑");
        }

        [TestMethod]
        public void TestLogSuccessConfig()
        {
            ILogFactory factory = new Log4NetLogFactory("log4netTest.config");
            ILog log = factory.GetLog("unitTest");
            log.ErrorFormat("发生了错误:{0}", "我就开个玩笑");
        }
    }
}
