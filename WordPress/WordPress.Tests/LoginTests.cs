
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPress.Framework.Browser;
using WordPress.Framework.Factories;
using WordPress.Framework.Pages;
using WordPress.Tests.Base;

namespace WordPress.Tests
{
    [TestClass]
    public class LoginTests : BaseTest
    {

        [TestMethod]
        public void USer_Can_Loguin()
        {
            //Validation
            Assert.IsTrue(PageFactory.GetPage<DashboardPage>().IsAt, "Error, you are not in the DashBoardPage");
        }

        //[TestMethod]
        //public void USer_Can_Loguin2()
        //{
        //    //Test Steps
        //  Assert.IsTrue(
        //    PageFactory.GetPage<LoginPage2>()
        //        .GoTo()
        //        .LoginAs("Gonzalo")
        //        .WithPassword("Control123!")
        //        .Login()
        //        .DashboardPage
        //        .IsAt
        //        , "Error, you are not in the DashBoardPage");
        //}

    }
}
