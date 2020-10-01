using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWagonAutomationAzure.Pages
{
    public class Logout
    {
        IWebDriver driver;
        public Logout(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_lnkbtnLogout")]
        IWebElement logoutBtn;

        public void LogoutPage()
        {
            logoutBtn.Click();
        }
    }
}
