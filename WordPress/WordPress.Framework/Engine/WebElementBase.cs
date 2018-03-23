

using OpenQA.Selenium;
using System.Collections.ObjectModel;

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
        }

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
