using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace PassionCore.Utilities
{
    public static class SeleniumExecutors
    {
        private static IWebDriver webDriver;
        public static ISearchContext SearchContext => Driver();

        public static IWebDriver Driver()
        {
            return webDriver ?? (webDriver = Initialize());

        }
        public static IWebDriver Initialize()
        {
            var options = new ChromeOptions();
            options.AddArgument("-----start maximized------");
            return webDriver = new ChromeDriver();
        }
        public static void Close()
        {
            webDriver.Close();
        }
        public static WebDriverWait GetWaitDriver(int timeout=0)
        {
            var waitTimeOut = timeout == 0 ? int.Parse(ConfigurationManager.AppSettings["waitTimeOut"]) : timeout;
               
                     return new WebDriverWait(Driver(),TimeSpan.FromSeconds(waitTimeOut));
        }
            
        public static void ITakesScreenshot(String fileName)
        {
            var requiredPath = FileHelper.GetScreenShotPath();
            var dateAndTime = String.Format("{0:yyyy-mm-dd_hh-mm-ss-fff}", DateTime.Now);
            var filePath=string.Format(@"{0}{1}-{2}.jpg", requiredPath, fileName, dateAndTime);
            Screenshot ss = ((ITakesScreenshot)webDriver).GetScreenshot();
            ss.SaveAsFile(filePath, ScreenshotImageFormat.Png);
        }


    }
}
