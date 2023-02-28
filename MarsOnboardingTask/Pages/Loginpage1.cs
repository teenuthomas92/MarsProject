using Mars_project_Task1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mars_project_Task1.Tests
{
    public class Loginpage1
    {
        IWebDriver driver;
        By signinButton = By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a");
        By emailAddress = By.Name("email");
        By password = By.Name("password");
        By loginButton = By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button");

        public Loginpage1(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void clickOnSignin()
        {
            driver.FindElement(signinButton).Click();
        }

        public void typeEmailaddress()
        {
            this.driver.FindElement(emailAddress).SendKeys("teenuthomas93@gmail.com");
        }

        public void typepassword()
        {
            this.driver.FindElement(password).SendKeys("121212");

        }
        public void clickOnLoginButton()
        {
            this.driver.FindElement(loginButton).Click();
        }

        public void SignInActions()
        {
            this.clickOnSignin();
            this.typeEmailaddress();
            this.typepassword();
            this.clickOnLoginButton();
        }




    }

}



