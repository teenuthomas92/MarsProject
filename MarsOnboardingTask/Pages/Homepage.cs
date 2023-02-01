using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsOnboardingTask.Utilities;

namespace MarsOnboardingTask.Pages
{
    internal class Homepage
    {

        public void GotoProfilePage(IWebDriver driver)
        {
           
            IWebElement hiTeenuMenu = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
            hiTeenuMenu.Click();
            Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div/a[1]", 20);
            IWebElement goToProfile = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div/a[1]"));
            goToProfile.Click();

        }
    }
}
