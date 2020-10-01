﻿using OpenQA.Selenium;
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

        [FindsBy(How = How.XPath, Using = "//div[@id='header']//li[1]")]
        IWebElement LoginBtn1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='ctl00$phBody$SignIn$txtEmail']")]
        IWebElement email { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='ctl00$phBody$SignIn$txtPassword']")]
        IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='ctl00$phBody$SignIn$btnLogin']")]
        IWebElement LoginBtn2 { get; set; }

        public void LoginPage()
        {
            Thread.Sleep(6000);
            email.SendKeys(Email);
            Thread.Sleep(3000);
            password.SendKeys(Password);
            Thread.Sleep(3000);
            LoginBtn2.Click();
        }
    }
}
