using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.Pages.Locators
{
    class MenuPageLocator
    {
        public By GreenTeaCheckOutButton => By.Id("wsb-button-00000000-0000-0000-0000-000451955160");
        public By RedTeaCheckOutButton => By.Id("wsb-button-00000000-0000-0000-0000-000451959280']");

        public By OolangcheckoutButton => By.Id("wsb-button-00000000-0000-0000-0000-000451961556");

        public By MenuPageHeader => By.XPath("//h1[text()='Menu']");

        public By SectionPageHeader => By.XPath("//span/strong[text()='{text}'");


    } 
}
