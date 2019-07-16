using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PassionCore.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.Core
{
    public static class ElementLocatorExtensions
    {
        public static IWebElement GetElement(this By elementLocator,IWebElement ParentElement=null)
        {
            try
            {
                var element=ParentElement ?? SeleniumExecutors.SearchContext;
                return element.FindElement(elementLocator);
            }
            catch(NoSuchElementException)
            {
                return null;
            }
            catch(TargetInvocationException)
            {
                return null;
            }
        }
        public static IWebElement GetElementWithWait(this By elementLocator)
        {
            Wait.ForElementTOBeVisible(elementLocator);
            return elementLocator.GetElement();
        }
        public static void ClickWithWait(this By elementLocator)
        {
            elementLocator.GetElementWithWait().Click();
        }
        public static bool IsDisplayedAfterWait(this By elementLoctor)
        {
            try
            {
                return elementLoctor.GetElementWithWait().Displayed;
            }
            catch(WebDriverTimeoutException)
            {
                return false;
            }

        }
        public static bool IsDisplayed(this By elementLocator)
        {
            try
            {
                return elementLocator.GetElement().Displayed;
            }
            catch(WebDriverTimeoutException)
            {
                return false;
            }
        }
        public  static void SendKeysWithWait(this By elementLocator, String text)
        {
            elementLocator.GetElementWithWait().SendKeys(text);
        }
        public static SelectElement GetSelectElement(this By elementLocalization)
        {
            return new SelectElement(elementLocalization.GetElementWithWait());
        }
        public static void SelectText(this By elementLocator, String text)
        {
            var select = elementLocator.GetSelectElement();
            select.SelectByText(text);
        }
    }
}
