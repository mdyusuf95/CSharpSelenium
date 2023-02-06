using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.POM
{
    public  class LogInPage
    {
        [FindsBy(How = How.Name, Using = ("user_name"))]
        private IWebElement UserNameBox { get; set; }

        [FindsBy(How = How.Name, Using = ("user_password"))]
        private IWebElement PasswordBox { get; set; }

        [FindsBy(How = How.Id, Using = ("submitButton"))]
        private IWebElement logInButton { get; set; }

        public LogInPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        public void SetLogIn(String usrnamr, String Password)
        {
            UserNameBox.SendKeys(usrnamr);
            PasswordBox.SendKeys(usrnamr);
            logInButton.Click();


        }
    }
}
