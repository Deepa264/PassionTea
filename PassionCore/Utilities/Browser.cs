using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionCore.Utilities
{
  public static class Browser
    {
        public static void GoToUrl( string url)
        {
            SeleniumExecutors.Driver().Navigate().GoToUrl(url);
        }
    }
}
