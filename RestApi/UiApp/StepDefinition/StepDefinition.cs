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
        public Settings settings = new Settings();
        #region Given 
        [Given(@"User is log in")]
        public void GivenUserIsLogIn()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.ClickLogin();
            loginPage.EnterLoginCredentials(ConfigurationManager.AppSettings["UserName"], ConfigurationManager.AppSettings["Password"]);
            loginPage.GoTodoPage();
        }
        #endregion
        #region Then
        [Given(@"I click on settings")]
        public void GivenIClickOnSettings()
        {
            
            settings.ClickSettings();
        }

        #endregion



        #region Then
        #endregion

        #region When
        #endregion
        [Given(@"I enter incorrect password")]
        public void GivenIEnterIncorrectPassword()
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
            IAlert alert = DriverPage.Instance._driver.SwitchTo().Alert();
            var text = alert.Text;
            alert.Accept();
            DriverPage.Instance._driver.SwitchTo().DefaultContent();
            Assert.AreEqual(text, "Invalid Password");
        }


    }
}
