using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasNetProject.GenericUtil.ScrollUtil
{
    public class ScrollHoriZontal
    {
        public static void Hover(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.ClickAndHold(element).MoveByOffset(10000, 0).Release().Perform();
            
        }
    }
}
