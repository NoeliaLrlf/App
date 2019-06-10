using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;

namespace UiApp.Page.DriverPage
{
    public class DriverPage
    {
        public IWebDriver _driver { get; set; }
        private static DriverPage _instance = null;

        private DriverPage()
        {

        }

        public static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");

            return option;
        }

        public IWebDriver GetWebDriver()
        {
            _driver = BaseClass.InitWebdriver();
          
            return _driver;
        }
        public void StartBrowser(string url)
        {
            _driver = GetWebDriver();

            _driver.Navigate().GoToUrl(url);


        }

        public void StopBrowser()
        {
            if (_driver!= null)
            {
                _driver.Close();
                _driver.Quit();
                _driver = null;
            }
        }

        public static DriverPage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DriverPage();
                }
                return _instance;
            }
        }
    }
}
