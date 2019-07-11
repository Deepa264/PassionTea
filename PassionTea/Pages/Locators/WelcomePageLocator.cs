using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PassionTea.Pages
{
    class WelcomePageLocator
    {
        public By SeaColletionHerbalTeaButton => By.CssSelector("a[id$='000450914890']");

        public By SeaColletionLooseteaColletionButton = By.CssSelector("a[id$='000450914897']");

        public By SeaColletionFlavouredTeaCollectionButton = By.CssSelector("a[id$='000450914899']");

       public By LetsTalkTeaLink => By.LinkText($"{ConstantValues.LetsTalkTeaHeaderText}");

      public By PageHeader =>By.XPath($"//h1[Contains(.,\"{ConstantValues.WelcomePageHeaderText}\")]");

    }
}
