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
    public class Cart
    {
        public IWebDriver driver;

        public Cart(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//body/div/div/div/div/div/iframe[1]")]
        public IWebElement placeOrderFrame { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='qtytext']")]
        public IWebElement quantity { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='btn-red']")]
        public IWebElement placeorder { get; set; }

        public void CartPage()
        {
            driver.SwitchTo().Frame(placeOrderFrame);
            Thread.Sleep(3000);
            quantity.Clear();
            Thread.Sleep(2000);
            quantity.SendKeys("2");
            Thread.Sleep(2000);
            placeorder.Click();
        }
    }
}
