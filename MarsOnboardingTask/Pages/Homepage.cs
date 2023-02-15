using Mars_project_Task1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_project_Task1.Pages
{
    public class Homepage :CommonDriver
    {
        By hiTeenuMenu = By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span");
        By goToProfile = By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div/a[1]");

        protected IWebDriver driver;

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void clickOnhiTeenuMenu()
        {
           Thread.Sleep(2000);
          driver.FindElement(hiTeenuMenu).Click();
        }


        public void clickOngoToProfile()
        {
            Thread.Sleep(3000);
            //Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div/a[1]", 20);
            driver.FindElement(goToProfile).Click();
        }

        public void GotoProfilePage()
        {
            Thread.Sleep(1000);
            this.clickOnhiTeenuMenu();
            this.clickOngoToProfile();   
            
        }
    }
}
