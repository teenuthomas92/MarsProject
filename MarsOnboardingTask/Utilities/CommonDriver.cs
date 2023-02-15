using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars_project_Task1.Tests;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace Mars_project_Task1.Utilities
{
    public class CommonDriver
    {
        public  IWebDriver driver;
        [OneTimeSetUp]
        public void LoginSteps()
        {
            this.driver = new ChromeDriver();
            this.driver.Manage().Window.Maximize();
            this.driver.Navigate().GoToUrl("http://localhost:5000/");
        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {

            driver.Quit();
        }
    }
}
