using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThomasNetProject.BrowserStack;

namespace ThomasNetProject.PageUtility.Screenshots
{
    public class ScreenshotPage
    {
        static int ScreenCounter = 0;
        public static string Path;
       
        public static void TakesScreenshotWithDate(string FileName, System.Drawing.Imaging.ImageFormat Format)
        {
            ScreenCounter++;
            StringBuilder TimeAndDate = new StringBuilder(DateTime.Now.ToString());
            TimeAndDate.Replace("/", "_");
            TimeAndDate.Replace(":", "_");

            ((ITakesScreenshot)SelectBrowser.driver).GetScreenshot().SaveAsFile(Path + ScreenCounter.ToString() + "." + FileName + TimeAndDate.ToString() + "." + Format);

        }
    }
}
