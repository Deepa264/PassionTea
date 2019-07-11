using NUnit.Framework;
using PassionTea.Builders;
using PassionTea.Core;
using PassionTea.Enum;
using PassionTea.Pages.Executors;
using PassionTea.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PassionTea.Tests
{
   
    public sealed class PassionTeaStepDefination
    {
        
        private readonly MenuPageExecutor menuPageExecutor = new MenuPageExecutor();
        private readonly WelcomePageExecutor welcomePageExecutor = new WelcomePageExecutor();
        private readonly CheckOutPageExecutors checkOutPageExecutor = new CheckOutPageExecutors();
        private readonly FeedBackPageExecutor feedBackPageExecutor = new FeedBackPageExecutor();

        [Given(@"I will go to passion tea homepage")]
        public void GivenIWillGoToPassionTeaHomepage()
        {
            Browser.GoToUrl(ConfigurationManager.AppSettings["PassionTea"]);
        }

        [Then(@"i see passion tea homepage")]
        public void ThenISeePassionTeaHomepage()
        {
            Assert.IsTrue(this.welcomePageExecutor.PageHeader.IsDisplayedAfterWait(), $"{ConstantValues.WelcomePageHeaderText}Header is not Displayed");
        }

        [Given(@"I will open Herbal tea collections")]
        public void GivenIWillOpenHerbalTeaCollections()
        {
            this.welcomePageExecutor.ClickOnHerbalTeaCollectionButton();
        }

        [When(@"I select Green Tea and place an order")]
        public void WhenISelectGreenTeaAndPlaceAnOrder()
        {
            this.menuPageExecutor.ClickOnGreenTeaButton();
            var checkOutDetails = BuilderCheckOutForm.BuildCheckOutDetails(CardType.MasterCard);
            this.checkOutPageExecutor.CompleteCheckoutFormAndSubmit(checkOutDetails);
        }

        [Then(@"I see a order confirmation page")]
        public void ThenISeeAOrderConfirmationPage()
        {
            Assert.IsTrue(this.checkOutPageExecutor.ConfirmationPageHeader.IsDisplayedAfterWait(),$"Page Header'{ConstantValues.CheckOutConfirmationPageHeaderText} is not displayed");
        }

        [Given(@"I will open Loose tea collections")]
        public void GivenIWillOpenLooseTeaCollections()
        {
            this.welcomePageExecutor.ClickOnLooseTeaCollectionButton();
        }

        [When(@"I select Oolang tea and place an order")]
        public void WhenISelectOolangTeaAndPlaceAnOrder()
        {
            this.menuPageExecutor.ClickOnOolongTeaButton();
            var checkOutDetails = BuilderCheckOutForm.BuildCheckOutDetails(CardType.Visa);
            this.checkOutPageExecutor.CompleteCheckoutFormAndSubmit(checkOutDetails);
        }

        [Given(@"I will go the Let's talk Tea page")]
        public void GivenIWillGoTheLetSTalkTeaPage()
        {
            this.welcomePageExecutor.LetsTalkTeaLink.ClickWithWait();
        }

        [When(@"I willcomplete the feedback form")]
        public void WhenIWillcompleteTheFeedbackForm()
        {
            var feedbackDetails = BuilderFeedBackForm.BuildFeedbackDetails();
            this.feedBackPageExecutor.CompleteFeedbackForm(feedbackDetails);

        }

        [Then(@"I can submit the form and get confirmation")]
        public void ThenICanSubmitTheFormAndGetConfirmation()
        {
            this.feedBackPageExecutor.SubmitButton.ClickWithWait();
            Assert.IsTrue(this.feedBackPageExecutor.feedbackConfirmationHeaderPage.IsDisplayedAfterWait(), $"PageHeader{ConstantValues.FeedbackConfirmationHeaderText}is not displayed");
        }
    }

}

