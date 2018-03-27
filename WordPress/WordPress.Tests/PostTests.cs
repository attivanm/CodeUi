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
            PageFactory.GetPage<LoginPage2>()
                .GoTo()
                .LoginAs("Gonzalo")
                .WithPassword("Control123!")
                .Login();
            //create Post
            PageFactory.GetPage<AddNewPostPage>()
            
                .GoTo()
                .SetTittle(title)
                .SetBody(body)
                .Publish();

            PageFactory.GetPage<EditPostPage>()
                .ViewPost(); // Option 2

            //validation
            //1
            Assert.IsTrue(PageFactory.GetPage<PostPage>().ValidateTitle(title));
            //2.
            PageFactory.GetPage<PostPage>().ValidateTitle2(title);

        }


        [TestMethod]
        public void Can_Search_Post()
        {
            //variables
            var title = StringManager.GenerateTitle();
            var body = StringManager.GenerateBody();
            
            // Precondition : create Post


            //Test Steps
            PageFactory.GetPage<AllPostsPage>()
                .GoTo()
                .SearchPost(title)
                .DoesPostExistWithTitle(title)
                ;

        }

        [TestCleanup]
        public void clean()
        {
            BrowserManager.Instance.Close();
        }
    }
}
