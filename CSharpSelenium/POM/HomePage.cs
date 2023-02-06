using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.POM
{
    public class HomePage
    {
        [FindsBy(How = How.XPath, Using = "//a[text()='Calendar']")]
        private IWebElement calaner { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Leads']")]
        private IWebElement lesds { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Organizations'] ")]
        private IWebElement Organizations { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Contacts'] ")]
        private IWebElement Contacts { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Opportunities'] ")]
        private IWebElement Opportunities { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Products'] ")]
        private IWebElement Products { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Documents'] ")]
        private IWebElement Documents { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Email'] ")]
        private IWebElement Email { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Trouble Tickets'] ")]
        private IWebElement TroubleTickets { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Dashboard'] ")]
        private IWebElement Dashboard { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='More'] ")]
        private IWebElement More { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[@src='themes/softed/images/user.PNG']")]
        private IWebElement Administrator { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[.='Sign Out']")]
        private IWebElement SignOutbtn { get; set; }

        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public IWebElement GetOrganizations()
        {
            return Organizations;

        }
        public IWebElement GetAdministrator()
        {
            return Administrator;

        }

        public IWebElement GetSignOut()
        {
            return SignOutbtn;

        }
    }
}
