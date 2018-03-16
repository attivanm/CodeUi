

using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace WordPress.Framework.Pages
{
    public class DashboardPage
    {
        public bool IsAt
        {
            get {
                    var h1s =
                    Browser.BrowserManager.Instance.Driver
                        .FindElements(By.TagName("h1"));

                    if (h1s != null && h1s.Count > 0) {
                        return h1s[0].Text.Equals("Dashboard");
                    }
                    return false;
                }
         }
    }
}
