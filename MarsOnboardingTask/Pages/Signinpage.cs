using MarsOnboardingTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsOnboardingTask.Pages
{
    internal class Signinpage
    {
        public void SignInActions(IWebDriver driver)
        {

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");

            IWebElement signinButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signinButton.Click();

            // Locate the element you want to wait for
            IWebElement emailidTextbox = driver.FindElement(By.Name("email"));
            
            // Identify email textbox and enter valid email
            emailidTextbox.SendKeys("teenuthomas93@gmail.com");

            // Identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
            passwordTextbox.SendKeys("121212");

            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            Wait.WaitForElementToExist(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span", 20);
         
            
            //Check whether logined successfully
            IWebElement HiTeenu = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
            Thread.Sleep(1000);
            String HiTeenuString = HiTeenu.Text;
            Assert.IsTrue(HiTeenuString.Contains("Hi Teenu"), "Login Failed");

        }


    }
}