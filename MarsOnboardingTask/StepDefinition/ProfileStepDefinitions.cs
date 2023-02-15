using Mars_project_Task1.Pages;
using Mars_project_Task1.Tests;
using Mars_project_Task1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;

namespace Mars_project_Task1.StepDefinition
{
    [Binding]
    public class ProfileStepDefinitions : CommonDriver
    {
        private Homepage homepage;
        private Loginpage loginpage;
        private LanguageMenu languageMenu;

        
        public ProfileStepDefinitions()
        {
               if (driver == null)
                {
                    this.LoginSteps();
               }
            homepage = new Homepage(driver);
            loginpage = new Loginpage(driver);
            languageMenu = new LanguageMenu(driver);
        }

        [Given(@"I am on the Languages tab of my profile page")]
        public void GivenIAmOnTheLanguagesTabOfMyProfilePage()
        {
            loginpage.SignInActions();
            homepage.GotoProfilePage();
        }

        [When(@"I click on the Add New button")]
        public void WhenIClickOnTheAddNewButton()
        {
            languageMenu.clickOnlanguageMenu();
            languageMenu.clickOnaddNewButton();
        }

        [When(@"I add my language information including '([^']*)', '([^']*)'")]
        public void WhenIAddMyLanguageInformationIncluding(string language, string level)
        {
            languageMenu.typeLanguage(language);
            languageMenu.clickOnlanguageLevel(level);
        }

        [When(@"I click on the Add button")]
        public void WhenIClickOnTheAddButton()
        {
            languageMenu.clickOnaddButton();
        }

        [Then(@"I am able to see my language details including '([^']*)', '([^']*)'")]
        public void ThenIAmAbleToSeeMyLanguageDetailsIncluding(string language, string level)
        {
            string newlanguage = languageMenu.Getlanguage();
            Assert.That(newlanguage == language, "Language not created.");
        }

        [Given(@"I am on the Language tab of my profile page")]
        public void GivenIAmOnTheLanguageTabOfMyProfilePage()
        {
            loginpage.SignInActions();
            homepage.GotoProfilePage();
        }

        [When(@"I click on the Edit icon next to the language information I want to edit")]
        public void WhenIClickOnTheEditIconNextToTheLanguageInformationIWantToEdit()
        {
            languageMenu.clickOneditLanguageIcon();
        }

        [When(@"I modify the language information including '([^']*)', '([^']*)'")]
        public void WhenIModifyTheLanguageInformationIncluding(string language, string level)
        {
            languageMenu.typeEditedlanguage(language);
            languageMenu.clickOnlanguageLevel(level);

        }

        [When(@"I click on the Update button")]
        public void WhenIClickOnTheUpdateButton()
        {
            languageMenu.clickOnupdateButton();
        }

        [Then(@"the updated language information should be displayed including '([^']*)', '([^']*)' in the language section of my profile page")]
        public void ThenTheUpdatedLanguageInformationShouldBeDisplayedIncludingInTheLanguageSectionOfMyProfilePage(string langauge, string level)
        {
            string editedlanguage = languageMenu.getEditedLanguage();
            Assert.That(editedlanguage == langauge, "Actual code and expected code do not match.");
        }

        [Given(@"I am on Language tab of my profile page")]
        public void GivenIAmOnLanguageTabOfMyProfilePage()
        {
            loginpage.SignInActions();
            homepage.GotoProfilePage();
        }


        [When(@"I click on the Delete icon next to the language information I want to delete")]
        public void WhenIClickOnTheDeleteIconNextToTheLanguageInformationIWantToEdit()
        {
            languageMenu.clickOndeleteicon();
        }

        [Then(@"the deleted language information should no longer be displayed in the language section of my profile page")]
        public void ThenTheDeletedLanguageInformationShouldNoLongerBeDisplayedInTheLanguageSectionOfMyProfilePage()
        {
            Thread.Sleep(2000);
            int numberOfLanguagesAfter = languageMenu.getTbodyCount();
            Assert.AreEqual(languageMenu.numberOfLanguagesBefore - 1, numberOfLanguagesAfter);
        }

        [Given(@"I am on the Skill tab of my profile page")]
        public void GivenIAmOnTheSkillTabOfMyProfilePage()
        {
            throw new PendingStepException();
        }

        [When(@"I add my skill information including '([^']*)', '([^']*)'")]
        public void WhenIAddMySkillInformationIncluding(string java, string intermediate)
        {
            throw new PendingStepException();
        }

        [Then(@"I am able to see my skill details including '([^']*)', '([^']*)'")]
        public void ThenIAmAbleToSeeMySkillDetailsIncluding(string language, string intermediate)
        {
            throw new PendingStepException();
        }

        [Given(@"I am in the skill tab of my profile page")]
        public void GivenIAmInTheSkillTabOfMyProfilePage()
        {
            throw new PendingStepException();
        }

        [When(@"I click on the Edit icon next to the skill information I want to edit")]
        public void WhenIClickOnTheEditIconNextToTheSkillInformationIWantToEdit()
        {
            throw new PendingStepException();
        }

        [When(@"I modify the skill information including '([^']*)', '([^']*)'")]
        public void WhenIModifyTheSkillInformationIncluding(string java, string intermediate)
        {
            throw new PendingStepException();
        }

        [Then(@"the updated skill information should be displayed including '([^']*)', '([^']*)'the skill section of my profile page")]
        public void ThenTheUpdatedSkillInformationShouldBeDisplayedIncludingTheSkillSectionOfMyProfilePage(string java, string intermediate)
        {
            throw new PendingStepException();
        }

        [Given(@"I am on the skill tab of my profile page")]
        public void GivenIAmOnSkillTabOfMyProfilePage()
        {
            throw new PendingStepException();
        }
        [When(@"I click on the Delete icon next to the skill information I want to delete")]
        public void WhenIClickOnTheDeleteIconNextToTheskillInformationIWantToEdit()
        {
            throw new PendingStepException();
        }

        [Then(@"the deleted skill information should no longer be displayed in the Skill section of my profile page")]
        public void ThenTheDeletedSkillInformationShouldNoLongerBeDisplayedInTheSkillSectionOfMyProfilePage()
        {
            throw new PendingStepException();
        }

        [Given(@"I am on the Education tab of my profile page")]
        public void GivenIAmOnTheEducationTabOfMyProfilePage()
        {
            throw new PendingStepException();
        }

        [When(@"I add my education information including '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)'")]
        public void WhenIAddMyEducationInformationIncluding(string country, string mG, string p2, string graduation, string p4)
        {
            throw new PendingStepException();
        }

        [Then(@"I am able to see my education details including '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)'")]
        public void ThenIAmAbleToSeeMyEducationDetailsIncluding(string country, string mG, string p2, string graduation, string p4)
        {
            throw new PendingStepException();
        }

        [When(@"I modify the education information including '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)'")]
        public void WhenIModifyTheEducationInformationIncluding(string country, string mG, string p2, string graduation, string p4)
        {
            throw new PendingStepException();
        }

        [Then(@"the updated education information should be displayed including '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)' in the Education section of my profile page")]
        public void ThenTheUpdatedEducationInformationShouldBeDisplayedIncludingInTheEducationSectionOfMyProfilePage(string country, string mG, string p2, string graduation, string p4)
        {
            throw new PendingStepException();
        }

        [When(@"I click on the Delete icon next to the education information I want to delete")]
        public void WhenIClickOnTheDeleteIconNextToTheEducationInformationIWantToEdit()
        {
            throw new PendingStepException();
        }

        [Then(@"the deleted education information should no longer be displayed in the Education section of my profile page")]
        public void ThenTheDeletedEducationInformationShouldNoLongerBeDisplayedInTheEducationSectionOfMyProfilePage()
        {
            throw new PendingStepException();
        }

        [Given(@"I am on the Certifications tab of my profile page")]
        public void GivenIAmOnTheCertificationsTabOfMyProfilePage()
        {
            throw new PendingStepException();
        }

        [When(@"I add my certifications information including '([^']*)', '([^']*)', '([^']*)'")]
        public void WhenIAddMyCertificationsInformationIncluding(string p0, string udemy, string p2)
        {
            throw new PendingStepException();
        }

        [Then(@"I am able to see my certifications details including '([^']*)', '([^']*)', '([^']*)'")]
        public void ThenIAmAbleToSeeMyCertificationsDetailsIncluding(string p0, string udemy, string p2)
        {
            throw new PendingStepException();
        }

        [When(@"I modify the Certification information including '([^']*)', '([^']*)', '([^']*)'")]
        public void WhenIModifyTheCertificationInformationIncluding(string p0, string udemy, string p2)
        {
            throw new PendingStepException();
        }

        [Then(@"the updated Certifications information should be displayed including '([^']*)', '([^']*)', '([^']*)' in the Certification section of my profile page")]
        public void ThenTheUpdatedCertificationsInformationShouldBeDisplayedIncludingInTheCertificationSectionOfMyProfilePage(string p0, string udemy, string p2)
        {
            throw new PendingStepException();
        }

        [When(@"I click on the Delete icon next to the Certifications information I want to edit")]
        public void WhenIClickOnTheDeleteIconNextToTheCertificationsInformationIWantToEdit()
        {
            throw new PendingStepException();
        }

        [Then(@"the deleted certification information should no longer be displayed in the Certification section of my profile page")]
        public void ThenTheDeletedCertificationInformationShouldNoLongerBeDisplayedInTheCertificationSectionOfMyProfilePage()
        {
            throw new PendingStepException();
        }
    }
}
