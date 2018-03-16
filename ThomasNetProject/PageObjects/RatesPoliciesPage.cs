using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThomasNetProject.BrowserStack;

namespace ThomasNetProject.PageObjects
{
    public class RatesPoliciesPage
    {
        private static IWebElement element = null;
        
        public static IWebElement SalesPolicies(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//span[contains(text(),'Rates & Policies')]"));
            return element;
        }

        public static IWebElement WForm(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//a[contains(text(),'W9 Form')]"));
            return element;
        }





    }
}
