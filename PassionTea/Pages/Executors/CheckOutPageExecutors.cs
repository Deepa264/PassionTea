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
    class CheckOutPageExecutors : CheckoutPageLocator
    {
        public void CompleteCheckoutFormAndSubmit(ModelFormCheckOut model)
        {
            EmailTextBox.SendKeysWithWait(model.EmailID);
            NameTextBox.SendKeysWithWait(model.Name);
            AddressTextBox.SendKeysWithWait(model.Name);
            CardTypeDropdownMenu.SendKeysWithWait(model.CardType);
            CardNumberTextBox.SendKeysWithWait(model.CardNumber.ToString());
            CardHolderNameTextBox.SendKeysWithWait(model.CardHoldName);
            VerificationCodeTextBox.SendKeysWithWait(model.VerificationCode.ToString());
            PlaceOrderButton.ClickWithWait();


        }
    }
}