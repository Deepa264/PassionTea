using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.Pages.Locators
{
    class FeedbackPageLocator
    {
        public By EmailInputTextBox => By.Name("email");
        public By NameInpuTextBox => By.Name("name");

        public By SubjectInputTextBox => By.Name("Messsage");

        public By SubmitButton => By.ClassName("form-submit");

        public By feedbackConfirmationHeaderPage => By.XPath($"//h1[text()='{ConstantValues.FeedbackConfirmationHeaderText}']'");

      public By PageHeader => By.XPath($"//h1[contains(.,\"{ConstantValues.LetsTalkTeaHeaderText}\")]");

       }
}
