using PassionTea.Core;
using PassionTea.Pages.Locators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace PassionTea.Pages.Executors
{
    class MenuPageExecutor : MenuPageLocator
       {
        public void ClickOnGreenTeaButton()
        {
            GreenTeaCheckOutButton.IsDisplayedAfterWait().Should().Betrue();
            GreenTeaCheckOutButton.ClickWithWait();
        }
        public void ClickOnRedTeaButton()
        {
            RedTeaCheckOutButton.IsDisplayedAfterWait().Should().Betrue();
            RedTeaCheckOutButton.ClickWithWait();
        }
        public void ClickOnOolongTeaButton()
        {
            OolangcheckoutButton.IsDisplayedAfterWait().Should().Betrue();
            OolangcheckoutButton.ClickWithWait();
        }
    }
}
