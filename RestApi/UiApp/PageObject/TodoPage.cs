using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UiApp.ComponentHelper;

namespace UiApp.PageObject
{
    public class TodoPage
    {
        public void ClickProject()
        {
            ButtonHelper.ClickButton(By.XPath("//*[@id='TitleProjects']"));
            ButtonHelper.ClickButton(By.XPath("//*[@id='TitleProjects']"));
          ButtonHelper.ClickButton(By.XPath("//*[@id='mainProjectList']/parent::*/descendant::td[@class='ProjItemContent'][1]"));
         }

         public void ClickDeleteProject()
        {
            ButtonHelper.ClickButton(By.XPath("//*[@id='mainProjectList']/parent::*/descendant::td[@class='ProjItemContent'][1]/following::img[1]"));
            
        }

        public void DeleteProject()
        {
            ButtonHelper.ClickButton(By.XPath("//*[@id='mainProjectList']/parent::*/descendant::td[@class='ProjItemContent'][1]/following::ul[@id='projectContextMenu']//a[@href='#delete'] "));
           
        }
    }
}
