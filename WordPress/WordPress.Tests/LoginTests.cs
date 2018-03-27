﻿
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPress.Framework.Browser;
using WordPress.Framework.Factories;
using WordPress.Framework.Pages;

namespace WordPress.Tests
{
    [TestClass]
    public class LoginTests
    {

        [TestInitialize]
        public void Init() {
            BrowserManager.Instance.Init();
           
        }

        [TestMethod]
        public void USer_Can_Loguin()
        {
            //Test Steps
            LoginPage.GoTo();
            LoginPage.LoginAs("Gonzalo")
                      .WithPassword("Control123!")
                      .Login();
            //Validation
            Assert.IsTrue(PageFactory.GetPage<DashboardPage>().IsAt, "Error, you are not in the DashBoardPage");
        }

        [TestMethod]
        public void USer_Can_Loguin2()
        {
            //Test Steps
          Assert.IsTrue(
            PageFactory.GetPage<LoginPage2>()
                .GoTo()
                .LoginAs("Gonzalo")
                .WithPassword("Control123!")
                .Login()
                .DashboardPage
                .IsAt
                , "Error, you are not in the DashBoardPage");
        }

        [TestCleanup]
        public void clean() {
            BrowserManager.Instance.Close();
        }
    }
}
