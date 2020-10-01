using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;
using System.Threading;

namespace BooksWagonAutomationAzure.Pages
{
    public class Login
    {
        readonly string Email = ConfigurationManager.AppSettings["email"];
        readonly string Password = ConfigurationManager.AppSettings["password"];

        public IWebDriver driver;
        public Login(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

      //  [FindsBy(How = How.XPath, Using = "//input[@class='_2zrpKA _1dBPDZ']")]
      //  IWebElement PageHeader;

        [FindsBy(How = How.XPath, Using = "//input[@id='ctl00_phBody_SignIn_txtEmail']")]
        IWebElement email;

        [FindsBy(How = How.XPath, Using = "//input[@id='ctl00_phBody_SignIn_txtPassword']")]
        IWebElement password;

        [FindsBy(How = How.XPath, Using = "//input[@id='ctl00_phBody_SignIn_btnLogin']")]
        IWebElement LoginBtnFinal;

        public void LoginPage()
        {
           // PageHeader.Click();
            Thread.Sleep(3000);
            email.SendKeys(Email);
            Thread.Sleep(3000);
            password.SendKeys(Password);
            Thread.Sleep(3000);
            LoginBtnFinal.Click();
        }
    }
}
