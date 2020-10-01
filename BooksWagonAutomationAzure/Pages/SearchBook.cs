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

        [FindsBy(How = How.CssSelector, Using = "#ctl00_imglogo")]
        IWebElement Logo;

        [FindsBy(How = How.XPath, Using = "//input[@id='ctl00_TopSearch1_txtSearch']")]
        IWebElement SearchBox;

        [FindsBy(How = How.XPath, Using = "//body/form[@id='aspnetForm']/div[@id='site-wrapper']/div[3]/div[3]/div[2]/div[1]/div[4]/div[5]/a[1]/input[1]")]
        IWebElement BuyBtn;

        public void SearchBookPage()
        {
            Logo.Click();
            Thread.Sleep(2000);
            SearchBox.Click();
            Thread.Sleep(2000);
            SearchBox.SendKeys(BookName + Keys.Enter);
            Thread.Sleep(3000);
            BuyBtn.Click();
            Thread.Sleep(1000);
        }
    }
}
