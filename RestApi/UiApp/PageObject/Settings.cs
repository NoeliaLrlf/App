using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UiApp.ComponentHelper;
using OpenQA.Selenium.Support.UI;
using UiApp.Page.DriverPage;

namespace UiApp.PageObject
{
    public class Settings
    {
        public WebDriverWait wait = new WebDriverWait(DriverPage.Instance._driver, TimeSpan.FromSeconds(10));
        public void EnterFullName()
        {
            TextBoxHelper.TypeInTextBox(By.Id("FullNameInput"),"23");
        }
        public void ClickSettings()
        {
            ButtonHelper.ClickButton(By.XPath("//a[text()='Settings']"));
        }
        public void EnterOldPassword()
        {
            var locator = By.Id("TextPwOld");
            GenericHelper.WaitForElement(locator);
            TextBoxHelper.TypeInTextBox(locator, "Pass");
        }
        public void EnterTimeZone()
        {
            ComboBoxHelper.SelectElement(By.Id("DropDownTimezone"), "Venezuela Standard Time");
        }

        public void ClickDefaultSettings()
        {
            ButtonHelper.ClickButton(By.XPath("//a[text()='Default Settings']"));
        }
        public void SelectNewTasks()
        {
            ComboBoxHelper.SelectElement(By.Id("DropDownNewTaskDueDate"),"0");
        }

        public void SelectOthers()
        {
            CheckBoxHelper.CheckedCheckBox(By.XPath("//input[@id = 'CbShowContextRightClick']"));
        }

        public void ClickOkButton()
        {
            var locator = By.XPath("//span[text()='Ok']");
            GenericHelper.WaitForElement(locator);
           ButtonHelper.ClickButton(locator);
        }

        public void Alert()
        {
            GenericHelper.WaitForElementAlert();
               
        }

    }
}
