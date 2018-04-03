using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPress.Framework.Browser;

namespace WordPress.Framework.Pages
{
    public class AddNewPostPage : BasePostPage
    {
        public AddNewPostPage GoTo() {
            var element = BrowserManager.Instance.Driver.MouseHover(By.Id("menu-posts"));
            element.FindElement(By.LinkText("Add New")).Click();
            return this;
        }


    }
}
