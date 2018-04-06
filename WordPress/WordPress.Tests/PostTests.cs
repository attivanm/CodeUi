using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPress.Framework.Browser;
using WordPress.Framework.Factories;
using WordPress.Framework.Pages;
using WordPress.Framework.RestCalls;
using WordPress.Tests.Base;
using WordPress.Utilities;

namespace WordPress.Tests
{
    [TestClass]
    public class PostTests : BaseTest
    {


        [TestMethod]
        public void Can_Create_Post()
        {
            //Variables 
            //Random Values for Title and Body
            var title = StringManager.GenerateTitle();
            var body = StringManager.GenerateBody();
            //Test Steps
 
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
            PostCalls.CreatePost(title, body);

            //Test Steps
            PageFactory.GetPage<AllPostsPage>()
                .GoTo()
                .SearchPost(title)
                .DoesPostExistWithTitle(title)
                ;
        }

        [TestMethod]
        public void Can_Update_Post()
        {
            //variables
            var title = StringManager.GenerateTitle();
            var body = StringManager.GenerateBody();
            //
            var newTitle = StringManager.GenerateTitle();

            // Precondition : create Post
            PostCalls.CreatePost(title, body);

            //Test Steps
            PageFactory.GetPage<AllPostsPage>()
                .GoTo()
                .SearchPost(title)
                .SelectPostCreated(title)
                ;
            PageFactory.GetPage<EditPostPage>()
                .SetTittle(newTitle)
                .Publish();
                ;

            //Verification Steps
            PageFactory.GetPage<EditPostPage>()
                .ViewPost(); // Option 2

            //Validation
            PageFactory.GetPage<PostPage>().ValidateTitle2(title);
        }


    }
}
