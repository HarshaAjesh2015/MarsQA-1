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
    class SkillPage
    {
        public void selectSkill(IWebDriver driver)
        {
            Driver.TurnOnWait();
            IWebElement skillBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillBtn.Click();
            IWebElement addnewBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewBtn.Click();
        }
        public void addSkill(IWebDriver driver, string skill)
        {
            Thread.Sleep(2000);
            var skillTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            ExcelLibHelper.PopulateInCollection(@"D:\MVP Studio\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Skill");
            skillTextBox.SendKeys(ExcelLibHelper.ReadData(2, "Skills"));

            

            var skillDrpdwn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skillDrpdwn.Click();


            var skillLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
            skillLevel.Click();

        }
        public void saveSkill(IWebDriver driver)
        {
            

            var addBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addBtn.Click();

        }

    }
}

