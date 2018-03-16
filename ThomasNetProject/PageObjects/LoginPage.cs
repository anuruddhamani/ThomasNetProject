using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasNetProject.PageObjects
{

    public class LoginPage
    {
        private static IWebElement element = null;
        public static IWebElement LoginButton(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//input[@id='Login']"));
            return element;
        }

        public static IWebElement UsernameText(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//input[@id='username']"));
            return element;
        }

        public static IWebElement PasswordText(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//input[@id='password']"));
            return element;
        }

        public static IWebElement VerificationText(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//div[@class='pull-right refresh_info']"));
            return element;
        }

        public static IWebElement JeoPardyAccountsLink(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//a[@id='sales-stats-jeopardy']"));
            return element;
        }

    }
}
