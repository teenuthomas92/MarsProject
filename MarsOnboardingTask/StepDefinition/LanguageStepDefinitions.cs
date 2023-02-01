using MarsOnboardingTask.Pages;
using MarsOnboardingTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsOnboardingTask.StepDefinition
{
    [Binding]
    public class LanguageStepDefinitions : CommonDriver
    {
        private int numberOfLanguagesBefore;

        [Given(@"I logged into the SkillSwap portal successsfully")]
        public void GivenILoggedIntoTheSkillSwapPortalSuccesssfully()
        {
            driver = new ChromeDriver();
            Signinpage Signinpageobj = new Signinpage();
            Signinpageobj.SignInActions(driver);
        }

        [Given(@"I navigate to the Profile details")]
        public void GivenINavigateToTheProfileDetails()
        {
            Homepage HomePageobj = new Homepage();
            HomePageobj.GotoProfilePage(driver);
        }

        [When(@"I checked whether the Language in Profile details can be addeed")]
        public void WhenICheckedWhetherTheLanguageInProfileDetailsCanBeAddeed()
        {
            LanguageMenu LanguageMenuobj = new LanguageMenu();
            LanguageMenuobj.CreateLanguage(driver);
        }

        [Then(@"Language are added successfully")]
        public void ThenLanguageAreAddedSuccessfully()
        {
            LanguageMenu LanguageMenuobj = new LanguageMenu();
            string newlanguage = LanguageMenuobj.Getlanguage(driver);
            Assert.That(newlanguage == "English", "Actual code and expected code do not match.");
        }

        [When(@"I checked whether the Language in Profile details can be edited")]
        public void WhenICheckedWhetherTheLanguageInProfileDetailsCanBeEdited()
        {
            LanguageMenu LanguageMenuobj = new LanguageMenu();
            LanguageMenuobj.EditLanguage(driver);
        }

        [Then(@"Language are edited successfully")]
        public void ThenLanguageAreEditedSuccessfully()
        {
            LanguageMenu LanguageMenuobj = new LanguageMenu();
            string editedlanguage = LanguageMenuobj.getEditedLanguage(driver);
            Assert.That(editedlanguage == "Spanish", "Actual code and expected code do not match.");
        }

        [When(@"I checked whether the Language in Profile details can be removed")]
        public void WhenICheckedWhetherTheLanguageInProfileDetailsCanBeRemoved()
        {
            LanguageMenu LanguageMenuobj = new LanguageMenu();
            this.numberOfLanguagesBefore = LanguageMenuobj.getTbodyCount(driver);
            LanguageMenuobj.DeleteLanguage(driver);
        }

        [Then(@"Language are removed successfully")]
        public void ThenLanguageAreRemovedSuccessfully()
        {
            LanguageMenu LanguageMenuobj = new LanguageMenu();
            int numberOfLanguagesAfter = LanguageMenuobj.getTbodyCount(driver);

            Assert.AreEqual(this.numberOfLanguagesBefore - 1, numberOfLanguagesAfter);

        }



    }
}