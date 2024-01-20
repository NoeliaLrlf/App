using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiApp.Page;
using UiApp.Page.DriverPage;

namespace UiApp.ComponentHelper
{
    public class GenericHelper 
    {

        public DriverPage DriverPage;
        public static WebDriverWait wait = new WebDriverWait(DriverPage.Instance._driver, TimeSpan.FromSeconds(10));
        public GenericHelper() 
        {
        
        }
       
        public static bool IsElementPresent(By Locator)
        {
           try
            {
                return DriverPage.Instance._driver.FindElements(Locator).Count == 1;
            }
            catch (Exception)
            {

                return false;
            }



        }
        public static IWebElement GetElement(By Locator)
        {
            if (IsElementPresent(Locator))
            {
                return DriverPage.Instance._driver.FindElement(Locator);
            }
            else
            {
                throw new NoSuchElementException("Element Not Found: " + Locator.ToString());
            }
        }

        public static void WaitForElement(By locator, string value = "visible")
        {
           
            switch (value)
            {
                case "visible":
                    wait.Until(ExpectedConditions.ElementIsVisible(locator));
                    break;
                default: throw new ArgumentNullException();
            
                    
            }
        }

        public static void WaitForElementAlert()
        {
            wait.Until(ExpectedConditions.AlertIsPresent());
               
        }
    }
}
