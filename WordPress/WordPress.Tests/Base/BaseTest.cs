using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPress.Framework.Browser;
using WordPress.Framework.Factories;
using WordPress.Framework.Pages;

namespace WordPress.Tests.Base
{
	[TestClass]
    public class BaseTest
    {
        [TestInitialize]
        public void Init()
        {
            BrowserManager.Instance.Init();
            PageFactory.GetPage<LoginPage2>()
                 .GoTo()
                 .LoginAs("Gonzalo")
                 .WithPassword("Control123!")
                 .Login();
        }

        [TestCleanup]
        public void clean()
        {
            BrowserManager.Instance.Close();
        }
    }
}
