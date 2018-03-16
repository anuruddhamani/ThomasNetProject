namespace ThomasNetProject.StepDefinitions
{
    using AventStack.ExtentReports;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using SikuliSharp;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TechTalk.SpecFlow;
    using ThomasNetProject.BrowserStack;
    using ThomasNetProject.ExcelReader;
    using ThomasNetProject.Hooks;
    using ThomasNetProject.PageObjects;
    using ThomasNetProject.PageUtility.PDFReaderFolder;
    using ThomasNetProject.PageUtility.Screenshots;
    using ThomasNetProject.PageUtility.Wait;

    /// <summary>
    /// Defines the <see cref="InitialPageSteps" />
    /// </summary>


    [Binding]
    public sealed class InitialPageSteps
    {
        /// <summary>
        /// Defines the rowscount, colcount
        /// </summary>


        /// <summary>
        /// The GivenUserShouldBeLandedSucessfullyOnTheHomePageAsWithTheProvidedUrl
        /// </summary>
        /// 
        int rowscount, colcount;
        ExtentReports extent = GeneralHooks.extent;
        ExtentTest test = GeneralHooks.test;

        string xlpath1 = @"C:\Users\Anuruddha.Tiwari\source\repos\ThomasNetProject\ThomasNetProject\TestData\Datareader.xlsx";

       [Given(@"User should be landed sucessfully on the home page as with the provided url")]
        public void GivenUserShouldBeLandedSucessfullyOnTheHomePageAsWithTheProvidedUrl()
        {
            try
            {
                
                Assert.IsTrue(InitialPage.SignInText(SelectBrowser.driver).Text.Equals("Sign In"));
                test.Info("Browser and URL launched Successfully");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
            }
        }


       


        /// <summary>
        /// The WhenUserClicksOnTheLoginWithSalesForceLink
        /// </summary>
        /// 

        [When(@"User Clicks on the login with SalesForce link")]
        public void WhenUserClicksOnTheLoginWithSalesForceLink()
        {
            try
            {
                Synchronization.VisibleElement(SelectBrowser.driver, By.LinkText("Login with Salesforce"));
                InitialPage.LoginButton(SelectBrowser.driver).Click();
                test.Log(Status.Pass, "Click on the Login Button");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        /// <summary>
        /// The ThenUserShouldNavigateToTheCredentialsPage
        /// </summary>
        [Then(@"user should navigate to the credentials page")]
        public void ThenUserShouldNavigateToTheCredentialsPage()
        {
            try
            {
                Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//input[@id='Login']"));
                Assert.IsTrue(LoginPage.LoginButton(SelectBrowser.driver).GetAttribute("name").Contains("Login"));
                test.Log(Status.Pass, "User Navigayed to the Credentials Page");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);

            }
        }

        /// <summary>
        /// The WhenEnterUsernameAndPassword
        /// </summary>
        [When(@"Enter username and password")]
        public void WhenEnterUsernameAndPassword()
        {
            try
            {
                LoginPage.UsernameText(SelectBrowser.driver).SendKeys(ExcelRead.GetCellData(xlpath1, @"UserCredentials", 1, 0));
                LoginPage.PasswordText(SelectBrowser.driver).SendKeys(ExcelRead.GetCellData(xlpath1, @"UserCredentials", 1, 1));
                test.Log(Status.Pass, "Enter Username and Password");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);

            }
        }

        /// <summary>
        /// The WhenClickOnTheLoginButton
        /// </summary>
        [When(@"Click on the login button")]
        public void WhenClickOnTheLoginButton()
        {
            try
            {
                Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//input[@id='Login']"));
                LoginPage.LoginButton(SelectBrowser.driver).Click();
                test.Log(Status.Pass, "Click on the Login to the SandBox");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);

            }
        }

        /// <summary>
        /// The ThenUserShouldSuccessfullyLandedToTheMainPage
        /// </summary>
        [Then(@"User should successfully landed to the Main Page")]
        public void ThenUserShouldSuccessfullyLandedToTheMainPage()
        {
            try
            {
                Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//div[@class='pull-right refresh_info']"));
                Assert.IsTrue(LoginPage.VerificationText(SelectBrowser.driver).Text.Contains("Information was refreshed"));
                test.Info("User Successfully Landed to the Main Page");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);

            }
        }

        /// <summary>
        /// The WhenUserClicksOnTheJeoPardyAccountsLink
        /// </summary>
        [When(@"User clicks on the JeoPardy Accounts link")]
        public void WhenUserClicksOnTheJeoPardyAccountsLink()
        {
            try
            {
                Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//a[@id='sales-stats-jeopardy']"));
                string text = LoginPage.JeoPardyAccountsLink(SelectBrowser.driver).Text;
                if (text.Equals("0 Jeopardy Accounts") == true)
                {
                    Console.WriteLine("No Accounts Listed");
                    ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
                    SelectBrowser.driver.Close();
                    test.Info("Browser Closes");
                }
                else
                {
                    LoginPage.JeoPardyAccountsLink(SelectBrowser.driver).Click();
                    test.Log(Status.Pass, "Click on the JeoPardy Accounts Link");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);

            }
        }

        /// <summary>
        /// The ThenUserShouldBeLandedSuccessfullyForJeopardyAccountsPage
        /// </summary>
        [Then(@"User should be landed successfully for jeopardy accounts page")]
        public void ThenUserShouldBeLandedSuccessfullyForJeopardyAccountsPage()
        {
            try
            {
                Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//h3[contains(text(),'Jeopardy Accounts')]"));
                Assert.IsTrue(AccountsPage.AccountsText(SelectBrowser.driver).Text.Contains("Jeopardy Accounts"));
                test.Log(Status.Info, "User Landed Successfully to the Jeopardy Account");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
            }
        }
        
        [When(@"user clicks on any of the account listed")]
        public void WhenUserClicksOnAnyOfTheAccountListed()
        {
            try
            {
                List<IWebElement> rows = new List<IWebElement>(AccountsPage.TableElement(SelectBrowser.driver).FindElements(By.TagName("tr")));
                rowscount = rows.Count;

                List<IWebElement> columns = new List<IWebElement>(SelectBrowser.driver.FindElements(By.XPath("//table[@id='accounts-jeopardy']//tbody//tr[1]/td")));
                colcount = columns.Count;

                for (int rownum = 1; rownum <= rowscount - 2; rownum++)
                {
                    List<IWebElement> rowCells = new List<IWebElement>(SelectBrowser.driver.FindElements(By.XPath("//table[@id='accounts-jeopardy']//tbody//tr[" + rownum + "]/td")));
                    for (int CellNumber = 0; CellNumber < rowCells.Count; CellNumber++)
                    {
                        string text = rowCells.ElementAt(CellNumber).Text;
                        IWebElement element = rowCells.ElementAt(CellNumber).FindElement(By.TagName("a"));
                        string textpresent = element.Text;
                        if (textpresent.Contains(ExcelRead.GetCellData(xlpath1, @"AccountsSheet",1,0))) 
                        {
                            Synchronization.VisibleElement(SelectBrowser.driver, By.TagName("a"));
                            element.Click();
                            test.Log(Status.Pass, "Clicked on the Account==>" + ExcelRead.GetCellData(xlpath1, @"AccountsSheet", 1, 0));
                            break;
                        }
                    }
                    break;
                }
                
                

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        /// <summary>
        /// The ThenUserShouldBeNavigatesToTheCorrectPage
        /// </summary>
        [Then(@"user should be navigates to the correct page")]
        public void ThenUserShouldBeNavigatesToTheCorrectPage()
        {
            try
            {
                string texttitle = SelectBrowser.driver.Url;
                Assert.IsTrue(texttitle.Contains(ExcelRead.GetCellData(xlpath1, @"AccountsSheet", 1, 0)));
                test.Log(Status.Pass, "User Navigated to the Specfic Account Page");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        
        [When(@"User clicks on the Invoices/Payments link")]
        public void WhenUserClicksOnTheInvoicesPaymentsLink()
        {
            try
            {                               
                Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//a[@ui-sref='Invoice/Payments']/col-md-"));                
                SpecificAccountInfo.Invoiceslink(SelectBrowser.driver).Click();
                test.Log(Status.Pass, "User Clicks on the Invoices and Payments Link");


            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);

            }
        }
        [When(@"click on the PDF link")]
        public void WhenClickOnThePDFLink()
        {
            try
            {
                using (var session = Sikuli.CreateSession())
                {
                    var img_text = Patterns.FromFile(@"C:\Users\ankit.kansal\Desktop\ImageText.PNG", 0.9f);
                    var print_text = Patterns.FromFile(@"C:\Users\ankit.kansal\Desktop\PrintImage.PNG", 0.9f);
                    session.Wait(img_text, 500);
                    session.DoubleClick(img_text);
                    test.Log(Status.Pass, "User Clicks on the PDF Icon");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);

            }
            
        }

        [Then(@"user should be verify that PDF data is validated")]
        public void ThenUserShouldBeVerifyThatPDFDataIsValidated()
        {
            //string path=
            try
            {
                Assert.IsTrue(PDFReaderP.ExtractPDF(@"C:\Users\ankit.kansal\Downloads\60149025.pdf").Contains("ThomasNet"));
                test.Info("User is verified succesfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);

            }
            
        }


        [When(@"Now, user clicks on the Recon link")]
        public void WhenNowUserClicksOnTheReconLink()
        {
            try
            {
                Synchronization.VisibleElement(SelectBrowser.driver, By.XPath("//col-md-[contains(text(),'Recon')]"));
                SpecificAccountInfo.ReconLink(SelectBrowser.driver).Click();
                test.Log(Status.Pass, "User Clicks on the Recon Link");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);

            }
        }
        [When(@"Click on the Print button")]
        public void WhenClickOnThePrintButton()
        {
            try
            {
                using (var session = Sikuli.CreateSession())
                {
                 
                    var print_text = Patterns.FromFile(@"C:\Users\ankit.kansal\Desktop\PrintImage.PNG", 0.9f);
                    session.Wait(print_text, 500);
                    session.Click(print_text);
                    test.Log(Status.Pass, "User Clicks on the Print button");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        [Then(@"user verifies the data")]
        public void ThenUserVerifiesTheData()
        {
            try
            {
                SelectBrowser.driver.SwitchTo().Window(SelectBrowser.driver.WindowHandles.Last());
                using (var session = Sikuli.CreateSession())
                {
                    var down_text = Patterns.FromFile(@"C:\Users\ankit.kansal\Desktop\Downloadbutton.PNG", 0.9f);
                    var save_button = Patterns.FromFile(@"C:\Users\ankit.kansal\Desktop\SaveButton.PNG", 0.9f);
                    session.Wait(down_text, 500);
                    session.Click(down_text);
                    test.Log(Status.Pass, "User Clicks on the Download Button");
                    session.Wait(save_button, 500);
                    session.Click(save_button);
                    test.Log(Status.Pass, "User Clicks on the Save Button");
                }

                Assert.IsTrue(PDFReaderP.ExtractPDF(@"C:\Users\ankit.kansal\Downloads\ReconReport_V9.pdf").Contains("Account"));
            }
            catch (AssertFailedException ex)
            {
                Console.WriteLine("Exception==>" + ex);
                ScreenshotPage.TakesScreenshotWithDate(@"Screesnhot", System.Drawing.Imaging.ImageFormat.Png);

            }
            
        }

        




    }
}
