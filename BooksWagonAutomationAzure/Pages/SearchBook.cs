using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksWagonAutomationAzure.Pages
{
    public class SearchBook
    {
        readonly string BookName = ConfigurationManager.AppSettings["bookName"];
        public IWebDriver driver;
        public SearchBook(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='search-input']//input")]
        IWebElement searchBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[1]//div[4]//div[5]//a[1]//input[1]")]
        IWebElement buyBtn { get; set; }

        public void SearchBookPage()
        {
            searchBox.SendKeys(BookName + Keys.Enter);
            Thread.Sleep(3000);
            buyBtn.Click();
            Thread.Sleep(1000);
        }
    }
}
