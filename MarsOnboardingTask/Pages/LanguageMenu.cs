using MarsOnboardingTask.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsOnboardingTask.Pages
{
    internal class LanguageMenu
    {
        
        public void CreateLanguage(IWebDriver driver)
        {
            //Create Language 
           
            IWebElement languageMenu = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languageMenu.Click();
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();
            IWebElement addLanguageTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguageTextBox.SendKeys("English");
            IWebElement languageDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            languageDropDown.Click();
            IWebElement languageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
            languageLevel.Click();
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
            Wait.WaitForElementToExist(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10);
        }

        public string Getlanguage(IWebDriver driver)
        {
            IWebElement actuallanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return actuallanguage.Text;
        }
        public void EditLanguage(IWebDriver driver)
        {
            //Edit Language
            Thread.Sleep(1000);
            IWebElement editLanguageicon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            editLanguageicon.Click();
            IWebElement editLanguageTextBox = driver.FindElement(By.Name("name"));
            editLanguageTextBox.Clear();
            editLanguageTextBox.SendKeys("Spanish");
            Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]",10);
           // Thread.Sleep(1000);
            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            updateButton.Click();
            Wait.WaitForElementToExist(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 20);
            //Thread.Sleep(3000);
        }

        public string getEditedLanguage(IWebDriver driver)
        {

            IWebElement editedLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return editedLanguage.Text;
        }


        public int getTbodyCount(IWebDriver driver)
        {
            IWebElement tableElement = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));
            IList<IWebElement> tbodiesElement = tableElement.FindElements(By.TagName("tbody"));
            int tbodyCount = tbodiesElement.Count;
            return tbodyCount;

        }
        public void DeleteLanguage(IWebDriver driver)
        {           

            IWebElement deleteicon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            deleteicon.Click();
        }






    }
}

