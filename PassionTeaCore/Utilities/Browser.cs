using PassionTea.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTeaCore.Utilities
{
  public static class Browser
    {
        public static void GoToUrl( string url)
        {
            SeleniumExecutors.Driver().Navigate().GoToUrl(url);
        }
    }
}
