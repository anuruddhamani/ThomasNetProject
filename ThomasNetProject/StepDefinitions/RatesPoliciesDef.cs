using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SikuliSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using ThomasNetProject.BrowserStack;
using ThomasNetProject.ExcelReader;
using ThomasNetProject.GenericUtil.ScrollUtil;
using ThomasNetProject.Hooks;
using ThomasNetProject.PageObjects;
using ThomasNetProject.PageUtility.PDFReaderFolder;
using ThomasNetProject.PageUtility.Screenshots;
using ThomasNetProject.PageUtility.Wait;

namespace ThomasNetProject.StepDefinitions
{
    [Binding]


   

    //Working on Salse Activity link
    public sealed class RatesPoliciesDef
    {
        IWebDriver driver = null;
        ExtentReports extent = GeneralHooks.extent;
        ExtentTest test = GeneralHooks.test;


        //Starting Scenario 01

        //User navigating to Rates & policies link

        [When(@"Click on the Rates & Policies")]
        public void WhenClickOnTheRatesPolicies()
        {
            try
            {
                Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//span[contains(text(),'Rates & Policies')]"));
                RatesPoliciesPage.SalesPolicies(SelectBrowser.driver).Click();
                test.Log(Status.Pass, "User Clicks on the Rates & Policies");

            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
            }
        }


        //click on W9Form under  Rates & Policies
        [Then(@"User should click on link WForm under  Rates & Policies")]
        public void ThenUserShouldClickOnLinkWFormUnderRatesPolicies()
        {
            try
            {
                Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//a[contains(text(),'W9 Form')]"));
                RatesPoliciesPage.WForm(SelectBrowser.driver).Click();
                test.Log(Status.Pass, "User Clicks on the W9Form under Rates & Policies");

            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
            }
        }



        //click on download link for pdf download in new opening window 

        [Then(@"User should click on download link for downloading pdf file")]
        public void ThenUserShouldClickOnDownloadLinkForDownloadingPdfFile()
        {

            try
            {
                
                SelectBrowser.driver.SwitchTo().Window(SelectBrowser.driver.WindowHandles.Last());
                //Assert.IsTrue(SelectBrowser.driver.Url.Contains("w9form"));
                using (var session = Sikuli.CreateSession())
                {
                    var down_text = Patterns.FromFile(@"C:\Users\Anuruddha.Tiwari\source\repos\ThomasNetProject\ThomasNetProject\Images\DownloadButton.PNG", 0.9f);
                    var save_button = Patterns.FromFile(@"C:\Users\Anuruddha.Tiwari\source\repos\ThomasNetProject\ThomasNetProject\Images\SaveButton.PNG", 0.9f);
                    session.Wait(down_text, 500);
                    session.Click(down_text);
                    test.Log(Status.Pass, "User Clicks on the Download Button");
                    session.Wait(save_button, 500);
                    session.Click(save_button);
                    test.Log(Status.Pass, "User Clicks on the Save Button");
                }

                //Assert.IsTrue(PDFReaderP.ExtractPDF(@"C:\Users\ankit.kansal\Downloads\ReconReport_V9.pdf").Contains("Account"));
            }
            catch (AssertFailedException ex)
            {
                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);

            }

        }















    }
}















