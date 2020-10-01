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
    public class ShippingAdd
    {
        readonly string Address = ConfigurationManager.AppSettings["address"];
        readonly string ReceipientName = ConfigurationManager.AppSettings["receipientName"];
        readonly string State = ConfigurationManager.AppSettings["state"];
        readonly string City = ConfigurationManager.AppSettings["city"];
        readonly string Pincode = ConfigurationManager.AppSettings["pincode"];
        readonly string MobileNo = ConfigurationManager.AppSettings["mobileNo"];

        public IWebDriver driver;
        public ShippingAdd(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewRecipientName")]
        IWebElement receipientName { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewAddress")]
        IWebElement address { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_ddlNewState")]
        IWebElement state { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewCity")]
        IWebElement city { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewPincode")]
        IWebElement pinCode;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewMobile")]
        IWebElement mobileNo { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_imgSaveNew")]
        IWebElement saveAndContinueBtn { get; set; }

        public void ShippingAddressPage()
        {
            receipientName.SendKeys(ReceipientName);
            Thread.Sleep(2000);
            address.SendKeys(Address);
            Thread.Sleep(2000);
            state.SendKeys(State);
            Thread.Sleep(2000);
            city.SendKeys(City);
            Thread.Sleep(2000);
            pinCode.SendKeys(Pincode);
            Thread.Sleep(2000);
            mobileNo.SendKeys(MobileNo);
            Thread.Sleep(2000);
            saveAndContinueBtn.Click();
        }
    }
}
