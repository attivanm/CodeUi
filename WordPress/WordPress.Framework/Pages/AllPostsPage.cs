using OpenQA.Selenium;
using System;
using WordPress.Framework.Browser;
using WordPress.Framework.Controls;
using WordPress.Framework.Engine;
using WordPress.Framework.Factory;

namespace WordPress.Framework.Pages
{
    public class AllPostsPage
    {
        public AllPostsPage GoTo() {
            // var element = BrowserManager.Instance.Driver.MouseHover(By.Id("menu-posts"));
            // element.FindElement(By.LinkText("Add New")).Click();

            ControlFactory.GetControl<ContainerElement>(Locator.Id, "menu-posts", "Left Menu")
                .MouseHover()
                .FindElementFromHere(By.LinkText("All Posts"))
                .Click();
                
            return this;
        }

        public AllPostsPage SearchPost(string title) {
            ControlFactory.GetControl<TextFieldElement>(Locator.Id, "post-search-input", "Search Post Input").SetValue(title);
            ControlFactory.GetControl<TextFieldElement>(Locator.Id, "search-submit", "Search Posts").Click();
            return this;
        }

        public void DoesPostExistWithTitle(string title) {
            var row =
            ControlFactory.GetControl<TableElement>(Locator.Id, "the-list", "Table All Post")
             .GetRow(title);
            if (row != null && row.Text.Contains(title)){
                //LOG 
            }
            else {
                //LOG
                throw new Exception("Title: " + title + "was not found in All Posts table");
            }

        }
    }
}
