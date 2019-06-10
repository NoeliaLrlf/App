using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UiApp.ComponentHelper;

namespace UiApp.PageObject
{
    public class Settings
    {
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
            TextBoxHelper.TypeInTextBox(By.Id("TextPwOld"), "Pass");
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
            ButtonHelper.ClickButton(By.XPath("//span[text()='Ok']"));
        }

    }
}
