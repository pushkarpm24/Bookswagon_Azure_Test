using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksWagonAutomationAzure.Pages
{
    public class ViewShoppingCart
    {

        IWebDriver driver;

        public ViewShoppingCart(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_ShoppingCart_lvCart_txtGiftMessage")]
        IWebElement giftMessage;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_ShoppingCart_lvCart_savecontinue")]
        IWebElement saveAndContinueBtn1;

        public void ViewShoppingCartPage()
        {
            Thread.Sleep(3000);
            saveAndContinueBtn1.Click();
            Thread.Sleep(1000);
        }
    }
}
