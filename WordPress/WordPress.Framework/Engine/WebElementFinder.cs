using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPress.Framework.Browser;

namespace WordPress.Framework.Engine
{
    public class WebElementFinder
    {
        private By _locator;
        private string _controlName;
        public WebElementFinder(WebElementBase elementBase) {
            _locator = elementBase.By;
            _controlName = elementBase.ControlName;
        }

        public IWebElement FindElement() {
            try
            {
                var element = SeleniumActions.GetWaitDriver.Until(d =>
                           d.FindElement(_locator));
                if (element != null)
                {
                    return element;
                }
                else
                {
                    string message = $"The Control: {_controlName} was not found";
                    throw new Exception(message);
                }
            }
            catch (NoSuchElementException)
            {
                //LOG
                string message = $"The Control: {_controlName} was not found";
                throw new Exception(message);
            }
            catch (StaleElementReferenceException)
            {
                //LOG
                string message = $"The Control: {_controlName} was not found";
                throw new Exception(message);
            }
            catch (Exception)
            {
                //LOG
                string message = $"The Control: {_controlName} was not found";
                throw new Exception(message);
            }
        }

        public ReadOnlyCollection<IWebElement> FindElements()
        {
            try
            {
                var element = SeleniumActions.GetWaitDriver.Until(d =>
                           d.FindElements(_locator));
                if (element != null)
                {
                    return element;
                }
                else
                {
                    string message = $"The Control: {_controlName} was not found";
                    throw new Exception(message);
                }
            }
            catch (NoSuchElementException)
            {
                //LOG
                string message = $"The Control: {_controlName} was not found";
                throw new Exception(message);
            }
            catch (StaleElementReferenceException)
            {
                //LOG
                string message = $"The Control: {_controlName} was not found";
                throw new Exception(message);
            }
            catch (Exception)
            {
                //LOG
                string message = $"The Control: {_controlName} was not found";
                throw new Exception(message);
            }
        }
    }
}
