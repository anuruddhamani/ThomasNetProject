using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasNetProject.PageUtility.Wait
{
    public class Synchronization
    {
        public static void VisibleElement(IWebDriver driver, By Locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
            wait.Until(ExpectedConditions.ElementIsVisible(Locator));
        }

        public static void ClickableElement(IWebDriver driver, By Locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            wait.Until(ExpectedConditions.ElementToBeClickable(Locator));
        }
    }
}
