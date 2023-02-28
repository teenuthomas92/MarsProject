using Mars_project_Task1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mars_project_Task1.Pages
{
    internal class LanguageMenu : CommonDriver
    {
         By languageMenu = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]");
         By addNewButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div");
         By addLanguageTextBox = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input");
         By languageDropDown = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select");
         By languageLevel = By.XPath("//option[@value='Basic' and text()='Basic']");
         By addButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]");
         By editLanguageIcon = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i");
         By editLanguageTextBox = By.Name("name");
         By updateButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]");
         By deleteicon = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i");

        public int numberOfLanguagesBefore;
        protected IWebDriver driver;
        public LanguageMenu(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void clickOnlanguageMenu()
        {
            Thread.Sleep(2000);
            driver.FindElement(languageMenu).Click();
        }

        public void clickOnaddNewButton()
        {
            Thread.Sleep(2000);
            driver.FindElement(addNewButton).Click();
        }
        
        public void typeLanguage(string language)
        {
            driver.FindElement(addLanguageTextBox).SendKeys(language);
        }


        public void clickOnlanguageDropDown()
        {
            driver.FindElement(languageDropDown).Click();
        }

        public void clickOnlanguageLevel(string level)
        {
            IWebElement dropdown = driver.FindElement(By.Name("level"));
            SelectElement select = new SelectElement(dropdown);
            // Select the option with the specified value
            select.SelectByValue(level);
        }

        public void clickOnaddButton()
        {
            driver.FindElement(addButton).Click();
        }

        public void clickOneditLanguageIcon()
        {
            driver.FindElement(editLanguageIcon).Click();
        }

        public void typeEditedlanguage(string language)
        {
            driver.FindElement(editLanguageTextBox).Clear();
            driver.FindElement(editLanguageTextBox).SendKeys(language);
        }

        public void clickOnupdateButton()
        {
            driver.FindElement(updateButton).Click();
        }

        public void clickOndeleteicon()
        {
            numberOfLanguagesBefore = getTbodyCount();
            driver.FindElement(deleteicon).Click();
        }


        public string Getlanguage()
        {
            Thread.Sleep(1000);
            IWebElement actuallanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return actuallanguage.Text;
        }
       

        public string getEditedLanguage()
        {
            
            IWebElement editedLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            Thread.Sleep(1000);
            return editedLanguage.Text;
        }


        public int getTbodyCount()
        {
            IWebElement tableElement = this.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));
            IList<IWebElement> tbodiesElement = tableElement.FindElements(By.TagName("tbody"));
            int tbodyCount = tbodiesElement.Count;
            return tbodyCount;
        }

       

    }
}
    