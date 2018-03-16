using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ThomasNetProject.BrowserStack
{
    public class SelectBrowser
    {
        public static IWebDriver driver = null;


        public static void BrowserandURL(string URL, string Browser)
        {
            if (Browser.Contains("Firefox"))
            {
                driver = new FirefoxDriver();
            }
            else if (Browser.Contains("Chrome"))
            {
                driver = new ChromeDriver();
            }
            else if (Browser.Contains("IE"))
            {
                driver = new InternetExplorerDriver();
            }

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(URL);
        }

        public static void BrowserTearDown()
        {
            driver.Close();
            driver.Quit();
        }


    }
}
