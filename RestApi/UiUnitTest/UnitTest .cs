using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UiApp.Page.DriverPage;
using System.Configuration;
using UiApp.ComponentHelper;
using UiApp.PageObject;
using OpenQA.Selenium;
using System.Threading;

namespace UiUnitTest
{
    [TestClass]
    public class UnitTest
    {
      
        [TestInitialize]
        public void Init()
        {
            DriverPage.Instance.StartBrowser(ConfigurationManager.AppSettings["Website"]);
        }

        [TestMethod]
        public void Login_EnterLogin_ValidValue_TodoPage()
        {
      
            LoginPage loginPage = new LoginPage();
            loginPage.ClickLogin();
            loginPage.EnterLoginCredentials(ConfigurationManager.AppSettings["UserName"], ConfigurationManager.AppSettings["Password"]);
            TodoPage page = loginPage.GoTodoPage();
            page.ClickProject();
            page.ClickDeleteProject();
         //   page.DeleteProject();
          

        }

        [TestMethod]
        public void Login_EnterLogin_InvalidValue_ErrorMessage()
        {

            LoginPage loginPage = new LoginPage();
            loginPage.ClickLogin();
            loginPage.EnterLoginCredentials("wrong", ConfigurationManager.AppSettings["Password"]);
            loginPage.GoTodoPage();
            var value = loginPage.GetError();
           
            Assert.IsTrue(value);  

        }

        [TestMethod]
        public void Setting_Update_ValidValue_ValueUpdated()
        {

            LoginPage loginPage = new LoginPage();
            loginPage.ClickLogin();
            loginPage.EnterLoginCredentials(ConfigurationManager.AppSettings["UserName"], ConfigurationManager.AppSettings["Password"]);
            loginPage.GoTodoPage();

            Settings settings = new Settings();
            settings.ClickSettings();
            settings.EnterTimeZone();
            settings.ClickDefaultSettings();
            settings.SelectNewTasks();
            settings.SelectOthers();
            settings.ClickOkButton();
            

    

        }

        [TestMethod]
        public void Setting_Update_InvalidValue_ErrorMessage()
        {

            LoginPage loginPage = new LoginPage();
            loginPage.ClickLogin();
            loginPage.EnterLoginCredentials(ConfigurationManager.AppSettings["UserName"], ConfigurationManager.AppSettings["Password"]);
            loginPage.GoTodoPage();
            Settings settings = new Settings();
            settings.ClickSettings();
            settings.EnterOldPassword();
            settings.ClickOkButton();
            IAlert alert = DriverPage.Instance._driver.SwitchTo().Alert();
            var text = alert.Text;
            alert.Accept();
            DriverPage.Instance._driver.SwitchTo().DefaultContent();
            Assert.AreEqual(text, "Invalid Password");

        }

        [TestCleanup]
        public void Clean()
        {
            DriverPage.Instance.StopBrowser();
        }
    }
}
