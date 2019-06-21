using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using UiApp.Page.DriverPage;
using UiApp.PageObject;

namespace UiApp.StepDefinition
{
    [Binding]
    public sealed class StepDefinition
    {
        public Settings settings;
        #region MyRegion
        [BeforeScenario]
        public void BeforeScenario()
        {
            DriverPage.Instance.StartBrowser(ConfigurationManager.AppSettings["Website"]);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverPage.Instance.StopBrowser();
        }

        

            #endregion
       

        [Given(@"User is log in")]
        public void GivenUserIsLogIn()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.ClickLogin();
            loginPage.EnterLoginCredentials(ConfigurationManager.AppSettings["UserName"], ConfigurationManager.AppSettings["Password"]);
            loginPage.GoTodoPage();
        }

        [When(@"I click on settings")]
        public void WhenIClickOnSettings()
        {
            settings            = new Settings();
            settings.ClickSettings();
        }

        [When(@"I enter incorrect password")]
        public void WhenIEnterIncorrectPassword()
        {
            settings.EnterOldPassword();
           
        }

        [When(@"I click Ok button")]
        public void WhenIClickOkButton()
        {
            settings.ClickOkButton();
        }

        [Then(@"A alert message should be displayed")]
        public void ThenAAlertMessageShouldBeDisplayed()
        {



            settings.Alert();
            IAlert alert        = DriverPage.Instance._driver.SwitchTo().Alert();
            var text            = alert.Text;
            alert.Accept();
            DriverPage.Instance._driver.SwitchTo().DefaultContent();
            Assert.AreEqual(text, "Invalid Password");
        }

    }
}
