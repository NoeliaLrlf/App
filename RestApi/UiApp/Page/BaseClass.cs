using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiApp.Page
{

    public class BaseClass
    {

        public static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");

            return option;
        }

        public static IWebDriver InitWebdriver()
        {

            IWebDriver driver = new ChromeDriver(@"C:\DriverChrome\", GetChromeOptions());

            return driver;

        }

     
    }
}
