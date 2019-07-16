using OpenQA.Selenium;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


namespace PassionCore.Utilities
{
   public static  class Wait
    {

        public static void ForElementTOBeVisible(By elementLocator,int timeout=0)
        {
            timeout = timeout == 0 ? int.Parse(ConfigurationManager.AppSettings["waitTimeOut"]) : timeout;
            try
            {
               // SeleniumExecutors.GetWaitDriver(timeout).Until(ExpectedConditions.)
              SeleniumExecutors.GetWaitDriver(timeout).Until(ExpectedCondition.ElementIsVisble(elementLocator));
               // SeleniumExecutors.GetWaitDriver(timeout).Until(Expected)
            }
            catch(WebDriverTimeoutException e)
            {
                throw new WebDriverTimeoutException($"Element with locator:'{elementLocator}' wasn't visible within timeout limlit", e);
            }
        }
    }
}
