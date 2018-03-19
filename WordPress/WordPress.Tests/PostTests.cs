using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPress.Framework.Browser;
using WordPress.Framework.Factories;
using WordPress.Framework.Pages;
using WordPress.Utilities;

namespace WordPress.Tests
{
    [TestClass]
    public class PostTests
    {
        [TestInitialize]
        public void Init()
        {
            BrowserManager.Instance.Init();

        }

        [TestMethod]
        public void Can_Create_Post()
        {
            //Variables 
            //Random Values for Title and Body
            var title = StringManager.GenerateTitle();
            var body = StringManager.GenerateBody();
            //Test Steps
            PageFactory<LoginPage2>.GetPage
                .GoTo()
                .LoginAs("Gonzalo")
                .WithPassword("Control123!")
                .Login();
            //create Post
            PageFactory<AddNewPostPage>.GetPage
            
                .GoTo()
                .SetTittle(title)
                .SetBody(body)
                .Publish();

            PageFactory<EditPostPage>.GetPage
                .ViewPost(); // Option 2

            //validation
            //1
            Assert.IsTrue(PageFactory<PostPage>.GetPage.ValidateTitle(title));
            //2.
            PageFactory<PostPage>.GetPage.ValidateTitle2(title);

        }

        [TestCleanup]
        public void clean()
        {
            BrowserManager.Instance.Close();
        }
    }
}
