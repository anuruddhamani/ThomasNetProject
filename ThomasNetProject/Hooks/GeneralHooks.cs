using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ThomasNetProject.BrowserStack;
using ThomasNetProject.ExcelReader;
using ThomasNetProject.GenericUtil.GenericHelper;
//using ThomasNetProject.Generic_Helper;
using ThomasNetProject.PageUtility.PDFReaderFolder;
using ThomasNetProject.PageUtility.Screenshots;

namespace ThomasNetProject.Hooks
{
    [Binding]
    public sealed class GeneralHooks
    {
        public static ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(@"C:\Users\Anuruddha.Tiwari\source\repos\ThomasNetProject\ThomasNetProject\Reports\Extentreports.html");
        public static ExtentReports extent = new ExtentReports();
        public static ExtentTest test;

        [BeforeFeature]
        public static void BeforeFeature()
        {


            extent.AddSystemInfo("URL", "test-salesdash.thomaspublishing.com");
            extent.AddSystemInfo("Username", "Ankit Kansal");
            //htmlReporter.LoadConfig(@"E:\Sample\ThomasPublishing\ThomasProject\ThomasProject\ThomasNetProject\ThomasNetProject\extent-config.xml");  

            htmlReporter.LoadConfig(@"C:\Users\Anuruddha.Tiwari\source\repos\ThomasNetProject\ThomasNetProject\extent-config.xml");
            SelectBrowser.BrowserandURL(ConfigurationManager.AppSettings.Get("Website"), ConfigurationManager.AppSettings.Get("Browser"));
            //ExcelRead.xlPath = ConfigurationManager.AppSettings.Get("FilePath");
            ScreenshotPage.Path = ConfigurationManager.AppSettings.Get("PathofScreenshot");
            Loghelper.appender = ConfigurationManager.AppSettings.Get("Appender");
            extent.AttachReporter(htmlReporter);
            //test = extent.CreateTest(FeatureContext.Current.FeatureInfo.Title);
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            test = extent.CreateTest("Running Scenario -->" + ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            if (ScenarioContext.Current.TestError != null)
            {
                var error = ScenarioContext.Current.TestError;
                var errormessage = "<pre>" + error.Message + "</pre>";
                extent.RemoveTest(test);
            }
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            SelectBrowser.BrowserTearDown();
            extent.Flush();
        }
    }
}
