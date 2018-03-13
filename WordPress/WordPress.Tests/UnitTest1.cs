using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPress.Framework.Browser;

namespace WordPress.Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void Init() {
            BrowserManager.Instance.Init();
            BrowserManager.Instance.GoTo();
        }

        [TestMethod]
        public void TestMethod1()
        {
            
        }

        [TestCleanup]
        public void clean() {
            BrowserManager.Instance.Close();
        }
    }
}
