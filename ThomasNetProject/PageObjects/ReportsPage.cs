using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasNetProject.PageObjects
{
    public class ReportsPage
    {
        private static IWebElement element = null;        
        public static IWebElement ReportsText(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//span[contains(text(),'Reports')]"));
            return element;
        }

        public static IWebElement SalesActivity(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//span[contains(text(),'Sales Activity')]"));
            return element;
        }

        public static IWebElement ViewReports(IWebDriver driver)
        {
            
            element = driver.FindElement(By.XPath("//button[contains(text(),'View Report')]"));
            return element;
            
        }

       /* public static IWebElement OutputType(IWebDriver driver)
        {

            element = driver.FindElement(By.XPath("//html//td[7]/child::div/div[@id='60232-77894']"));
            return element;

        }*/


        /* public static IWebElement HtmlOption(IWebDriver driver)
         {
              element = driver.FindElement(By.XPath("//div[@id='12697-52142']/select/option[1]"));


              return element;
          }*/



        /*public static IWebElement DareLink(IWebDriver driver)
        {

            element = driver.FindElement(By.XPath("//span[@class='shortcut-label'][contains(text(),'DARE')]"));
            return element;

        }*/
       







    }
}
