
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPress.Framework.Browser;
using WordPress.Framework.Factories;
using WordPress.Framework.Pages;

namespace WordPress.Tests
{
    [TestClass]
    public class UnitTest1
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
            Assert.IsTrue(PageFactory<DashboardPage>.GetPage.IsAt, "Error, you are not in the DashBoardPage");
        }

        [TestMethod]
        public void USer_Can_Loguin2()
        {
            //Test Steps
          Assert.IsTrue(
            PageFactory<LoginPage2>.GetPage
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
