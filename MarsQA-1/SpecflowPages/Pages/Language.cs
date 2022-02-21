using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Language
    {
        public void selectLanguage(IWebDriver driver)
        {

            Driver.TurnOnWait();
            IWebElement langBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            langBtn.Click();
            IWebElement addBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addBtn.Click();

        }

        public void addLanguage(IWebDriver driver, string language)
        {

            //var langTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            //langTextBox.SendKeys(language);
            Thread.Sleep(3000);

            var langTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            ExcelLibHelper.PopulateInCollection(@"D:\MVP Studio\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Language");
            langTextBox.SendKeys(ExcelLibHelper.ReadData(2, "Language"));

            var langDrpdwn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            langDrpdwn.Click();

            Driver.TurnOnWait();

            var choseLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
            choseLevel.Click();


        }

        public void saveLanguage(IWebDriver driver)
        {

            Driver.TurnOnWait();

            var addBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addBtn.Click();

        }
    }
}
