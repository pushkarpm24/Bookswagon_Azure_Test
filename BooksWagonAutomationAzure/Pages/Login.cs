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

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_txtEmail")]
        IWebElement email { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_txtPassword")]
        IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_btnLogin")]
        IWebElement LoginBtn2 { get; set; }

        public void LoginPage()
        {
            email.SendKeys(Email);
            Thread.Sleep(3000);
            password.SendKeys(Password);
            Thread.Sleep(3000);
            LoginBtn2.Click();
        }
    }
}
