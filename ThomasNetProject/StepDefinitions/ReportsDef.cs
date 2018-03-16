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
using ThomasNetProject.PageObjects;
using ThomasNetProject.PageUtility.PDFReaderFolder;
using ThomasNetProject.PageUtility.Screenshots;
using ThomasNetProject.PageUtility.Wait;

namespace ThomasNetProject.StepDefinitions
{
    [Binding]


    //Working on Salse Activity link
    public sealed class ReportsDef
    {
        IWebDriver driver = null;
        [When(@"User clicks on the Reports link")]
        public void WhenUserClicksOnTheReportsLink()
        {
            try
            {
                Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//span[contains(text(),'Reports')]"));
                ReportsPage.ReportsText(SelectBrowser.driver).Click();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        [Then(@"User should be landed successfully for reports page")]
        public void ThenUserShouldBeLandedSuccessfullyForReportsPage()
        {

            try
            {
                Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//h3[contains(text(),'Reports')]"));
                Assert.IsTrue(ReportsPage.ReportsText(SelectBrowser.driver).Text.Contains("Reports"));
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
            }

        }


        [When(@"User clicks on the Sales Activity link")]
        public void WhenUserClicksOnTheSalesActivityLink()
        {
            try
            {
                Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//span[contains(text(),'Sales Activity')]"));
                ReportsPage.SalesActivity(SelectBrowser.driver).Click();
                Thread.Sleep(10000);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
            }

        }


        [Then(@"User should be landed successfully for Sales Activity page")]
        public void ThenUserShouldBeLandedSuccessfullyForSalesActivityPage()
        {


            try
            {
                SelectBrowser.driver.SwitchTo().Window(SelectBrowser.driver.WindowHandles.Last());
                Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//button[@type='button']"));
                Assert.IsTrue(ReportsPage.ViewReports(SelectBrowser.driver).Text.Contains("View Report"));
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
            }

        }

        [When(@"User clicks on the View Reports link")]
        public void WhenUserClicksOnTheViewReportsLink()
        {
            try
            {
                SelectBrowser.driver.SwitchTo().Window(SelectBrowser.driver.WindowHandles.Last());
                Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//button[contains(text(),'View Report')]"));
                Thread.Sleep(10000);
                ReportsPage.ViewReports(SelectBrowser.driver).Click();


            }

            catch (Exception ex)
            {

                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
            }
        }
        [Then(@"User should be able to verify pdf succesfully")]
        public void ThenUserShouldBeAbleToVerifyPdfSuccesfully()
        {
            
            using (var session = Sikuli.CreateSession())
            {
                var Download_img = Patterns.FromFile(@"C:\Users\Anuruddha.Tiwari\Desktop\DownloadButton.PNG", 0.9f);
                var Save_img = Patterns.FromFile(@"C:\Users\Anuruddha.Tiwari\Desktop\SaveButton.PNG", 0.9f);
                session.Wait(Download_img, 100);
                session.Click(Download_img);
                session.Wait(Save_img, 100);
                session.Click(Save_img);
            }
        }
        [Then(@"user should be verify that PDF data/content is validated")]
        public void ThenUserShouldBeVerifyThatPDFDataContentIsValidated()
        {

            try
            {
                string filePath = @"C:\Users\Anuruddha.Tiwari\Downloads\SalesActivity.pdf";

                string path = @"C:\Users\Anuruddha.Tiwari\Downloads\SalesActivity.pdf";
                Assert.IsTrue(PDFReaderP.ExtractPDF(path).Contains("Content Activity Report"));
                Console.WriteLine("Assert Pass");
                Assert.IsTrue(path.Contains(".pdf"));
                Console.WriteLine("file extenssion is .pdf");



            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);


            }

        }
    }
}



/*[Given(@"User should be landed sucessfully on the View Report page as with the provided url")]
 public void GivenUserShouldBeLandedSucessfullyOnTheViewReportPageAsWithTheProvidedUrl()
 {
     try
     {
         SelectBrowser.driver.SwitchTo().Window(SelectBrowser.driver.WindowHandles.Last());
         Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//button[@type='button']"));
         Assert.IsTrue(ReportsPage.ViewReports(SelectBrowser.driver).Text.Contains("View Report"));
         IJavaScriptExecutor js = SelectBrowser.driver as IJavaScriptExecutor;
         System.Threading.Thread.Sleep(5000);
         js.ExecuteScript("window.scrollBy(1426,152)");
     }
     catch (Exception ex)
     {

         Console.WriteLine("Exception==>" + ex);
         ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
     }
 }
 */







/*  [When(@"User clicks on the Output Type")]
  public void WhenUserClicksOnTheOutputType()
  {
      try
      {

          using (var session = Sikuli.CreateSession())
          {


              var Option_img = Patterns.FromFile(@"C:\Users\Anuruddha.Tiwari\source\repos\ThomasNetProject\ThomasNetProject\Images\SelectOptions.PNG", 0.9f);
              session.Wait(Option_img, 10000);
              session.Click(Option_img);
              Console.WriteLine("Click done");

          }


      }
      catch (Exception ex)
      {

          Console.WriteLine("Exception==>" + ex);
          ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
      }
  }




  [Then(@"user should be see all options")]
   public void ThenUserShouldBeSeeAllOptions()
   {
       try
       {
           SelectElement oSelect = new SelectElement(driver.FindElement(By.Id("22948-70161")));
           IList<IWebElement> elementCount = oSelect.Options;
           Console.Write(elementCount.Count);
       }

       catch (Exception ex)
       {

           Console.WriteLine("Exception==>" + ex);
           ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
       }
   }
   */

/* [Then(@"User Select HTML \(Paginated\) option")]
  public void ThenUserSelectHTMLPaginatedOption()
  {

      try
      {
          Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//div[@id='12697-52142']/select/option[1]"));
         SelectElement sct = new SelectElement(driver.FindElement(By.XPath("//div[@id='12697-52142']/select/option[1]")));
         sct.SelectByText("HTML (Paginated)");

         ReportsPage.HtmlOption(SelectBrowser.driver);
         Thread.Sleep(10000);
      }
      catch (Exception ex)
      {

          Console.WriteLine("Exception==>" + ex);
          ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
      }

  }*/


   /* [Then(@"user should be click on the option")]
 public void ThenUserShouldBeClickOnTheOption()
 {
     try
     {
         Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//span[contains(text(),'Sales Activity')]"));
         ReportsPage.SalesActivity(SelectBrowser.driver).Click();
         Thread.Sleep(10000);
     }
     catch (Exception ex)
     {

         Console.WriteLine("Exception==>" + ex);
         ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
     }

 }
 */





//Working on dare link



//[When(@"User should be able to click on dare")]
//public void WhenUserShouldBeAbleToClickOnDare()
//{

//    try
//    {
//        Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//span[@class='shortcut-label'][contains(text(),'DARE')]"));
//        ReportsPage.DareLink(SelectBrowser.driver).Click();
//    }
//    catch (Exception ex)
//    {

//        Console.WriteLine("Exception==>" + ex);
//        ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
//    }

//}



//[Then(@"User should be landed successfully for dare page")]
//public void ThenUserShouldBeLandedSuccessfullyForDarePage()
//{

//    try
//    {
//        SelectBrowser.driver.SwitchTo().Window(SelectBrowser.driver.WindowHandles.Last());
//        Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//button[@type='button']"));
//        Assert.IsTrue(ReportsPage.ViewReports(SelectBrowser.driver).Text.Contains("View Report"));
//    }
//    catch (Exception ex)
//    {

//        Console.WriteLine("Exception==>" + ex);
//        ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
//    }

//}



//[When(@"User clicks on the View Reports link for dare")]
//public void WhenUserClicksOnTheViewReportsLinkForDare()
//{
//    try
//    {
//        Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//button[contains(text(),'View Report')]"));
//        Thread.Sleep(20000);
//        ReportsPage.ViewReports(SelectBrowser.driver).Click();


//    }

//    catch (Exception ex)
//    {

//        Console.WriteLine("Exception==>" + ex);
//        ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
//    }

//}



//[Then(@"Then user should be verify that PDF data/content is validated of dare")]
//public void ThenThenUserShouldBeVerifyThatPDFDataContentIsValidatedOfDare()
//{

//    using (var session = Sikuli.CreateSession())
//    {
//        var Download_img = Patterns.FromFile(@"C:\Users\Anuruddha.Tiwari\source\repos\ThomasNetProject\ThomasNetProject\Images\DownloadButton.PNG", 0.9f);
//        var Save_img = Patterns.FromFile(@"C:\Users\Anuruddha.Tiwari\source\repos\ThomasNetProject\ThomasNetProject\Images\SaveButton.PNG", 0.9f);
//        session.Wait(Download_img, 100);
//        session.Click(Download_img);
//        session.Wait(Save_img, 1000);
//        session.Click(Save_img);
//    }

//}












