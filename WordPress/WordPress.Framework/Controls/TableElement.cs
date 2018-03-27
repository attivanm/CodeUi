using OpenQA.Selenium;
using WordPress.Framework.Browser;
using WordPress.Framework.Engine;

namespace WordPress.Framework.Controls
{
    class TableElement : WebElementBase
    {
        private IWebElement _table;
        public TableElement()
        {
        }

        public TableElement(Locator locator, string value, string controlName)
            : base(locator, value, controlName)
        {
            _table = WebElement;
        }

        public IWebElement GetRow(string rowKey) {
            return _table.FindElementFromHere(By.XPath(".//tr[contains(.,'" + rowKey + "' )]"));
        }
    }
}
