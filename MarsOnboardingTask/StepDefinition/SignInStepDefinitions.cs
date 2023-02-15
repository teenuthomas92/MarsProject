using Mars_project_Task1.Pages;
using Mars_project_Task1.Tests;
using Mars_project_Task1.Utilities;
using TechTalk.SpecFlow;

namespace Mars_project_Task1.StepDefinition
{
    [Binding]
    public class SignInStepDefinitions : CommonDriver
    {
        private Homepage homepage;
        private Loginpage loginpage;

        public SignInStepDefinitions()
        {
            if (driver == null)
            {
                this.LoginSteps();
            }
            homepage = new Homepage(driver);
            loginpage = new Loginpage(driver);
        }

        [Given(@"the user is on the sign in page")]
        public void GivenTheUserIsOnTheSignInPage()
        {
            loginpage.clickOnSignin();
        }

        [When(@"the user enters the correct emailaddress and password")]
        public void WhenTheUserEntersTheCorrectEmailaddressAndPassword()
        {
            loginpage.typeEmailaddress();
            loginpage.typepassword();
        }

        [When(@"clicks the Login button")]
        public void WhenClicksTheLoginButton()
        {
            loginpage.clickOnLoginButton();
        }

        [Then(@"the user should be redirected to the profile page")]
        public void ThenTheUserShouldBeRedirectedToTheProfilePage()
        {
            homepage.clickOnhiTeenuMenu();
        }

        [When(@"the user enters the teenuthomas(.*)@gmail\.com and (.*)")]
        public void WhenTheUserEntersTheTeenuthomasGmail_ComAnd(int p0, int p1)
        {
            loginpage.typeEmailaddress();
            loginpage.typepassword();
        }

        [When(@"clicks the Login in button")]
        public void WhenClicksTheLoginInButton()
        {

            loginpage.clickOnLoginButton();
        }
    }
}
