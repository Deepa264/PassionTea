using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.Pages.Locators
{
    class CheckoutPageLocator
    {
        public By EmailTextBox => By.Id("email");
        public By NameTextBox => By.Id("name");

        public By AddressTextBox => By.XPath("//textarea[@id='address']");

        public By CardTypeDropdownMenu => By.XPath("//textarea[@id='address']");

        public By CardNumberTextBox => By.XPath("//input[@id='card_number']");

        public By CardHolderNameTextBox => By.Id("cardholder_name");

        public By VerificationCodeTextBox => By.Id("verification_code");

        public By PlaceOrderButton => By.ClassName("btn btn-primary");

       public By ConfirmationPageHeader => By.XPath($"//h1[text()='{MessageConstant.CheckOutConfirmationPageHeaderText}']");
    }
}
