

using OpenQA.Selenium;
using System.Collections.ObjectModel;
using WordPress.Framework.Browser;
using WordPress.Logger;

namespace WordPress.Framework.Engine
{
    public class WebElementBase
    {
        public By By{ get; set; }
        public string ControlName { get; set; }
        public WebElementBase() {
        }
        public WebElementBase(Locator locator, string value, string controlName) {
            ControlName = controlName;
            SearchProperty(locator, value);
        }

        private void SearchProperty(Locator locator, string value) {
            switch (locator)
            {
                case Locator.Id:
                    By = By.Id(value);
                    break;
                case Locator.Name:
                    By = By.Name(value);
                    break;
                case Locator.XPath:
                    By = By.XPath(value);
                    break;
                case Locator.LinkText:
                    By = By.LinkText(value);
                    break;
                case Locator.TagName:
                    By = By.TagName(value);
                    break;
                case Locator.CssSelector:
                    By = By.CssSelector(value);
                    break;
                case Locator.PartialLinkText:
                    By = By.PartialLinkText(value);
                    break;
                case Locator.ClassName:
                    By = By.ClassName(value);
                    break;
                default:
                    break;
            }
        }

        public void Click() {
            WebElement.Click();
            //Log example 1
            var message = $"The (Control)[{ControlName}] was clicked.";
            LoggerManager.Instance.Information(message);

            //log example 2
            var message2 = $"The (Button)[{ControlName}] is displayed.";
            //log example 3
           // var message3 = $"The (TextField)[{ControlName}] contains the WORNG value: [{currentValue}], when it should contain  the expected value [{expectedValue}].";

        }

        public IWebElement MouseHover() {
            return WebElement.MouseHover();
        }

        //GetText

        //DrawHighLight


        private IWebElement _webElement;

        public IWebElement WebElement
        {
            get {
                if (_webElement == null) {
                    var webElement = new WebElementFinder(this);
                    _webElement = webElement.FindElement();
                }
                return _webElement;
            }
        }

        private ReadOnlyCollection<IWebElement> _webElements;

        public ReadOnlyCollection<IWebElement> WebElements
        {
            get
            {
                if (_webElements == null)
                {
                    var webElement = new WebElementFinder(this);
                    _webElements = webElement.FindElements();
                }
                return _webElements;
            }
        }


    }
}
