using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.POM
{
    public class CreatingNewOrganization
    {
        [FindsBy(How = How.Name, Using = "accountname")]
        private IWebElement OrganizationNameg { get; set; }


        [FindsBy(How = How.Name, Using = "website")]
        private IWebElement website { get; set; }


        [FindsBy(How = How.Id, Using = "phone")]
        private IWebElement phone { get; set; }


        [FindsBy(How = How.Id, Using = "fax")]
        private IWebElement fax { get; set; }

        [FindsBy(How = How.Id, Using = "otherphone")]
        private IWebElement otherphone { get; set; }

        [FindsBy(How = How.Id, Using = "tickersymbol")]
        private IWebElement tickersymbol { get; set; }


        [FindsBy(How = How.Id, Using = "employees")]
        private IWebElement employees { get; set; }


        [FindsBy(How = How.Id, Using = "email1")]
        private IWebElement email1 { get; set; }


        [FindsBy(How = How.Id, Using = "email2")]
        private IWebElement email2 { get; set; }


        [FindsBy(How = How.Id, Using = "ownership")]
        private IWebElement emailownership { get; set; }

        [FindsBy(How = How.Name, Using = "industry")]
        private IWebElement industrydropBox { get; set; }


        [FindsBy(How = How.Name, Using = "rating")]
        private IWebElement ratingDopBox { get; set; }


        [FindsBy(How = How.Name, Using = "accounttype")]
        private IWebElement accounttypeDopBox { get; set; }


        [FindsBy(How = How.Id, Using = "siccode")]
        private IWebElement siccode { get; set; }


        [FindsBy(How = How.Name, Using = "emailoptout")]
        private IWebElement emailoptout { get; set; }


        [FindsBy(How = How.Name, Using = "annual_revenue")]
        private IWebElement annual_revenue { get; set; }



        [FindsBy(How = How.Name, Using = "notify_owner")]
        private IWebElement notify_owner { get; set; }


        [FindsBy(How = How.Name, Using = "bill_street")]
        private IWebElement bill_street { get; set; }


        [FindsBy(How = How.Name, Using = "button")]
        private IWebElement SaveButton { get; set; }



        public IWebElement GetOrganizationNameg()
        {
            return this.OrganizationNameg;
        }

        public IWebElement Getwebsite()
        {
            return this.website;
        }

        public IWebElement GetSvaeButton()
        {
            return this.SaveButton;
        }

        public CreatingNewOrganization(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

       
    }
}
