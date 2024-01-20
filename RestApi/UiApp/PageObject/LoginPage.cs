using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiApp.ComponentHelper;
using UiApp.Page.DriverPage;

namespace UiApp.PageObject
{
    public class LoginPage
    {

        public LoginPage()
        {



        }

        public void ClickLogin()
        {
            ButtonHelper.ClickButton(By.XPath("//img[@src='/Images/design/pagelogin.png']"));
        }
        public void EnterLoginCredentials(string email, string password)
        {
           TextBoxHelper.TypeInTextBox(By.XPath("//*[@id='ctl00_MainContent_LoginControl1_TextBoxEmail']"), email);
           TextBoxHelper.TypeInTextBox(By.XPath("//*[@id='ctl00_MainContent_LoginControl1_TextBoxPassword']"), password);

        }

        public TodoPage GoTodoPage()
        {
            ButtonHelper.ClickButton(By.XPath("//*[@id='ctl00_MainContent_LoginControl1_ButtonLogin']"));
            return new TodoPage();
        }

        public bool GetError()
        {
            try
            {
                IWebElement element = GenericHelper.GetElement(By.XPath("//*[text()='Wrong email or password. Please try again. Forgot your password? You can retrieve it using the form below.']"));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
         
        }
    }
}
