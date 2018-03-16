using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasNetProject.GenericUtil.SelectUtil
{
    public class SelectUtil
    {
        public static void SelectByNameMethod(IWebElement element, string data)
        {
            SelectElement se = new SelectElement(element);
            se.SelectByText(data);
        }
    }
}
