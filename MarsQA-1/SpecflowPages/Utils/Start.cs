using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {
        //[BeforeTestRun]
        //public static void BeforeTestRun()
        //{

        //}

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext context)
        {
            ExtentReports();
            // test = Extent.StartTest(context.FeatureInfo.Title);
        }

        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();
            //ExtentReports();
            ExcelLibHelper.PopulateInCollection(@"D:\MVP Studio\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");
            //call the SignIn class
            SignIn.SigninStep();
        }


        //[BeforeTestRun]
  //public static void startTest()

  //      {
  //          var report = new ExtentReports(System.Property("user.dir") + "ExtentReportResults.html");
  //          test = report.StartTest("ExtentReport");
  //      }


        [AfterScenario]
        public void TearDown()
        {

            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");

            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            //Close the browser
            Close();





            //end test.(Reports)
            CommonMethods.Extent.EndTest(test);

            // calling Flush writes everything to the log file (Reports)
            CommonMethods.Extent.Flush();



        }
    }
}
