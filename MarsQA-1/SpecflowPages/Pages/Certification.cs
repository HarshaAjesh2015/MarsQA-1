using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Certification
    {
        public void selectCertification(IWebDriver driver)
        {
            //WaitImplementation.WaitToBeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 2);

            Driver.TurnOnWait();
            var certifcateBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certifcateBtn.Click();
            var addnewBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addnewBtn.Click();
        }
        public void addCertification(IWebDriver driver, string certificate, string certifiedfrom, string year)
        {
            Thread.Sleep(2000);
            var certificateBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            ExcelLibHelper.PopulateInCollection(@"D:\MVP Studio\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Certification");
            certificateBox.SendKeys(ExcelLibHelper.ReadData(2, "Certification")); 

            var certificateFrom = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            ExcelLibHelper.PopulateInCollection(@"D:\MVP Studio\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Certification");
            certificateFrom.SendKeys(ExcelLibHelper.ReadData(2,"From"));

            SelectElement yeardrpdwn = new SelectElement(driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")));
            ExcelLibHelper.PopulateInCollection(@"D:\MVP Studio\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Certification");
            yeardrpdwn.SelectByText(ExcelLibHelper.ReadData(2, "Year"));

        }

        public void saveCertification(IWebDriver driver)
        {
            // WaitImplementation.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]", 2);

            Driver.TurnOnWait();
            var addBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addBtn.Click();
        }
    }
}
