using PassionTea.Core;
using PassionTea.Objects;
using PassionTea.Pages.Locators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.Pages.Executors
{
    class FeedBackPageExecutor :FeedbackPageLocator
    {

        public void CompleteFeedbackForm(ModelFormFeedBackPage model)
        {
            EmailInputTextBox.SendKeysWithWait(model.EmailID);
            NameInpuTextBox.SendKeysWithWait(model.Name);
            SubjectInputTextBox.SendKeysWithWait(model.Subject);
            SubmitButton.SendKeysWithWait(model.Message);
         }
    }
}
