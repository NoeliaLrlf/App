using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace UiApp.StepDefinition
{
    [Binding]
    public sealed class StepDefinition
    {
        [Given(@"User is log in")]
        public void GivenUserIsLogIn()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on settings")]
        public void WhenIClickOnSettings()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter incorrect password")]
        public void WhenIEnterIncorrectPassword()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click Ok button")]
        public void WhenIClickOkButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"A alert message should be displayed")]
        public void ThenAAlertMessageShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
