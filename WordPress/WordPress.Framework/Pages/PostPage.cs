using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPress.Framework.Browser;

namespace WordPress.Framework.Pages
{
    public class PostPage
    {
        public Boolean ValidateTitle(string expectedTitle) {
            var actualTitle = BrowserManager.Instance.Driver.FindElement(By.ClassName("entry-title")).Text;
            //LOGS
            return actualTitle.Equals(expectedTitle);
        }
        public void ValidateTitle2(string expectedTitle) {
            var actualTitle = BrowserManager.Instance.Driver.FindElement(By.ClassName("entry-title")).Text;
            if (!actualTitle.Equals(expectedTitle))
            {
                //ERROR 
                throw new Exception("Error: The titles are different: " +
                    "Actual Title: " + actualTitle +
                    "Expected Title: " + expectedTitle);
            }
            else {
                //GOOD
                //LOGS
            }
        }
    }
}
