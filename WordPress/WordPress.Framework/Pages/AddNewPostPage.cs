using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPress.Framework.Browser;

namespace WordPress.Framework.Pages
{
    public class AddNewPostPage
    {
        public AddNewPostPage GoTo() {
            var element = BrowserManager.Instance.Driver.MouseHover(By.Id("menu-posts"));
            element.FindElement(By.LinkText("Add New")).Click();
            return this;
        }

        public AddNewPostPage SetTittle(string title) {
            BrowserManager.Instance.Driver.FindElement(By.Id("title")).SendKeys(title);
            return this;
        }

        public AddNewPostPage SetBody(string body) {
            var iframe = BrowserManager.Instance.Driver.FindElement(By.Id("content_ifr"));
            BrowserManager.Instance.Driver.SwitchTo().Frame(iframe);
            //Im in the FRAME o IFRAME
            BrowserManager.Instance.Driver.SwitchTo().ActiveElement().SendKeys(body);
            //.. more FindElement

            //Switch DefaultContent
            BrowserManager.Instance.Driver.SwitchTo().DefaultContent();
            BrowserManager.Instance.Driver.Sleep();
            return this;
        }

        public void Publish() {
            var button = BrowserManager.Instance.Driver.FindElement(By.Id("publish"));
            // cuando la clase cambia automaticamente su estado 
            button.WaitForAttributeChange("class", "button button-primary button-large").Click();
        }
    }
}
