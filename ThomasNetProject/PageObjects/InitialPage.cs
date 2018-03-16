using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasNetProject.PageObjects
{
    public class InitialPage
    {
        private static IWebElement element = null;
        public static IWebElement SignInText(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//h1[contains(text(),'Sign In')]"));
            return element;
        }

        public static IWebElement LoginButton(IWebDriver driver)
        {
            element = driver.FindElement(By.LinkText("Login with Salesforce"));
            return element;
        }  


    }
}
