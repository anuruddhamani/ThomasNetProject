using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasNetProject.PageObjects
{
    public class SpecificAccountInfo
    {
        private static IWebElement element = null;
        public static IWebElement Invoiceslink(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//col-md-[contains(text(),'Invoice/Payments')]"));
            return element;
        }

        public static IWebElement SelectDropDown(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//select[@name='invRange']"));
            return element;
        }

        public static IWebElement ReconLink(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//col-md-[contains(text(),'Recon')]"));
            return element;
        }
    }
}
