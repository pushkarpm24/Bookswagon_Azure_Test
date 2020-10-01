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

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Login')]")]
        public IWebElement LoginBtn;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_txtEmail")]
        IWebElement email { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_txtPassword")]
        IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='ctl00_phBody_SignIn_btnLogin']")]
        IWebElement LoginBtnFinal { get; set; }

        public void LoginPage()
        {
            Thread.Sleep(40000);
            LoginBtn.Click();
            Thread.Sleep(3000);
            email.SendKeys(Email);
            Thread.Sleep(3000);
            password.SendKeys(Password);
            Thread.Sleep(3000);
            LoginBtnFinal.Click();
        }
    }
}
