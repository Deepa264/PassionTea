﻿using OpenQA.Selenium;
using PassionTea.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using  

namespace PassionTea.Utilities
{
   static  class Wait
    {
       // public static object ExpectedCondition { get; private set; }

        public static void ForElementTOBeVisible(By elementLocator,int timeout=0)
        {
            timeout = timeout == 0 ? int.Parse(ConfigurationManager.AppSettings["waitTimeOut"]) : timeout;
            try
            {
                 SeleniumExecutors.GetWaitDriver(timeout).Until(ExpectedConditions.ElementIsvisble(elementLocator));
               // SeleniumExecutors.GetWaitDriver(timeout).Until(Expected)
            }
            catch(WebDriverTimeoutException e)
            {
                throw new WebDriverTimeoutException($"Element with locator:'{elementLocator}' wasn't visible within timeout limlit", e);
            }
        }
    }
}
