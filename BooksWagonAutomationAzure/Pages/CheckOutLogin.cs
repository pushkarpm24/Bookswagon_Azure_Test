using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace BooksWagonAutomationAzure.Pages
{
    public class CheckOutLogin
    {
        public IWebDriver driver;

        public CheckOutLogin(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn-red']")]
        IWebElement continueBtn;

        public void CheckoutLoginPage()
        {
            Thread.Sleep(2000);
            continueBtn.Click();
        }
    }
}
