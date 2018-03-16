using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasNetProject.PageObjects
{
    public class ActivityHomePage
    {
        private static IWebElement element = null;

        // starting Scenario 01
        public static IWebElement ContentMainLink(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//div[contains(text(),'Content Maintenance')]"));
            return element;
        }


        public static IWebElement ContentMainLinkAlert(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//h4[@class='ng-binding']"));
            return element;
        }

      

        public static IWebElement FileDownloadLink(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//a[@class='excel-link pull-left']"));
            return element;
        }

        public static IWebElement TextContentMaintenance(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//div[contains(text(),'Content Maintenance')]"));
            return element;
        }

        public static IWebElement TextWindowContentMaintenance(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//h4[@class='ng-binding']"));
            return element;
        }

        public static IWebElement TextAmtContentMaintenance(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//div[@id='widget-content-quad2']//div[@class='ui-grid-viewport ng-isolate-scope']//div[1]/div[1]/div[3]"));
            return element;
        }

        public static IWebElement TexttotamtContentMaintenance(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//div[@tabindex='-1']//div[@ng-if='grid.options.showColumnFooter']//div[5]"));
            return element;
        }






        // starting Scenario 02


        public static IWebElement CloseButton(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//button[@class='btn btn-default pull-right']"));
            return element;
        }
        public static IWebElement CustomSpeckLink(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//span[contains(text(),'# Account')]//following::div[14]//following::div[1]"));
            return element;
        }

        public static IWebElement DownloadCustomSpeckLink(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//a[@class='excel-link pull-left']"));
            return element;
        }

        
        public static IWebElement TextCustomSpeck(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//div[contains(text(),'Content Maintenance')]//following::div[8]"));
            return element;
        }

        public static IWebElement TextWindowCustomSpeck(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//h4[@class='ng-binding']"));
            return element;
        }
        public static IWebElement TextAmtCustomSpeck(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//div[contains(text(),'Content Maintenance')]//following::div[11]"));
            return element;
        }

        public static IWebElement TexttotamtCustomSpeck(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//div[@tabindex='-1']//div[@ng-if='grid.options.showColumnFooter']//div[5]"));
            return element;
        }

       


        // starting Scenario 03

        public static IWebElement CustomSpeckImplementationLink(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//div[contains(text(),'Custom SPEC Implementation')]"));
            return element;
        }

        public static IWebElement DownloadCustomSpeckImplementationLink(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//a[@class='excel-link pull-left']"));
            return element;
        }
        public static IWebElement TextSpeckImplementation(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//div[contains(text(),'Custom SPEC Implementation')]"));
            return element;
        }

        public static IWebElement TextWindowSpeckImplementation(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//h4[@class='ng-binding']"));
            return element;
        }
        public static IWebElement TextAmtSpeckImplementation(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//div[@id='widget-content-quad2']//div[3]/div[1]/div[3]"));
            return element;
        }

        public static IWebElement TexttotamtSpeckImplementation(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//div[@tabindex='-1']//div[@ng-if='grid.options.showColumnFooter']//div[5]/div[1]"));
            return element;
        }

        




        // starting Scenario 04

        public static IWebElement DownloadPendingRenewalsLink(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//div[@class='span12 pending-renewal-gap']//div[@class='widget-header-highlite']/a"));
            return element;
        }


        public static IWebElement GlueLink(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//span[contains(text(),'(GMI) GLUECKLER METAL INC.')]//preceding::i[1]"));
            return element;
        }

        public static IWebElement text1(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//span[contains(text(),'(GMI) GLUECKLER METAL INC.')]"));
            return element;
        }

        public static IWebElement text2(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//div[@class='col-md-12']//div[@class='col-md-12']//h3"));
            return element;
        }

        public static IWebElement BillingNameHeader(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//span[contains(text(),'Billing Name')]"));
            return element;
        }

        public static IWebElement PubCodeHeader(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//span[contains(text(),'Pub Code')]"));
            return element;
        }

        public static IWebElement ContractEndHeader(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//span[contains(text(),'Contract End')]"));
            return element;
        }

        public static IWebElement ContractAmountHeader(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//span[contains(text(),'Contract Amount')]"));
            return element;
        }

        public static IWebElement SalesCloseHeader(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//span[contains(text(),'Sales Close')]"));
            return element;
        }



        //Starting Scenario 05 for Media Sales

        public static IWebElement DrillDownDisplay(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//option[@ng-repeat='item in quadOneOptions'][contains(text(),'Internet_TSpec_TNN')]"));
            return element;
        }

        public static IWebElement MediaDisplayDownloadLink(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//div[@class='span12']//div[@class='span12']//div[@class='widget-header-highlite']/a"));
            return element;
        }


        public static IWebElement MediaDisplayLink(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//div[contains(text(),'Mar 2018')]"));
            return element;
        }


        public static IWebElement MonthStartHeader(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//span[contains(text(),'Month Start')]"));
            return element;
        }

        public static IWebElement NewHeader(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//span[contains(text(),'New')]"));
            return element;
        }

        public static IWebElement RenewHeader(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//span[contains(text(),'Renew')]"));
            return element;
        }

        public static IWebElement TotalHeader(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//span[contains(text(),'Total')]"));
            return element;
        }

        public static IWebElement PyFinalHeader(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//span[contains(text(),'P Y Final')]"));
            return element;
        }

        public static IWebElement RateHeader(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//span[@class='ng-binding'][contains(text(),'Rate')]"));
            return element;
        }

        //Scroll Horizontal and WebElement Find
        public static IWebElement DeltaHeader(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//span[contains(text(),'Delta')]"));
            return element;
        }

        public static IWebElement InternetTspecTnn(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//h3[@class='ng-binding']"));
            return element;
        }


    }
}
