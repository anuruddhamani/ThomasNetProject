using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThomasNetProject.BrowserStack;

namespace ThomasNetProject.PageObjects
{
    public class AccountsPage
    {
        private static IWebElement element = null;
        private static List<IWebElement> noelement = null;
        public static IWebElement AccountsText(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//h3[contains(text(),'Jeopardy Accounts')]"));
            return element;
        }
        

        public static IWebElement TableElement(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//table[@id='accounts-jeopardy']"));
            return element;
        }
        

    }
}
