using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UiApp.Page.DriverPage;
using System.Configuration;
using UiApp.ComponentHelper;
using UiApp.PageObject;

namespace UiUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
     //       DriverPage.Instance.StartBrowser(ConfigurationManager.AppSettings["Website"]);
           
        }

        //[TestMethod]
        //public void TLogin()
        //{
        //  //  DriverPage.Instance.StartBrowser(ConfigurationManager.AppSettings["Website"]);
        //    LoginPage loginPage = new LoginPage(ConfigurationManager.AppSettings["Website"] );
        //    loginPage.ClickLogin();
        //    TodoPage page = loginPage.EnterLogin("shareackn@gmail.com", "ihateurmusic");
            
        //}
    }
}
