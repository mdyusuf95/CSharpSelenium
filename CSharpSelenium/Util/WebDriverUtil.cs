using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.Util
{
    public  class WebDriverUtil
    {
        public void GoToUrl(IWebDriver driver, String Url)
        {
            driver.Navigate().GoToUrl(Url);

        }

        public void implicityWaites(IWebDriver driver, int timeinseconds)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeinseconds);

        }

        public void AlertAcceptl(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Accept();

        }

        public void AlertDissmiss(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Dismiss();

        }

        public void DropDownhandelText(IWebElement element, String visbletext)
        {
            SelectElement s = new SelectElement(element);
            s.SelectByText(visbletext);
        }

        public void DropDownhandelIndex(IWebElement element, int index)
        {
            SelectElement s = new SelectElement(element);
            s.SelectByIndex(index);
        }

        public void DropDownhandelValue(IWebElement element, String value)
        {
            SelectElement s = new SelectElement(element);
            s.SelectByValue(value);

        }

        public void HandleFrames(IWebDriver driver, int index)
        {
            driver.SwitchTo().Frame(index);

        }

        public void HandleFrames(IWebDriver driver, IWebElement element)
        {
            driver.SwitchTo().Frame(element);

        }

        public void ActionMouseHover(IWebDriver driver, IWebElement element)
        {
            Actions a = new Actions(driver);
            a.MoveToElement(element);

        }

        public void ActoinRightClick(IWebDriver driver, IWebElement element)
        {
            Actions a = new Actions(driver);
            a.ContextClick(element);

        }

        public void ActoinRightClick(IWebDriver driver, String window)
        {
            driver.SwitchTo().Window(window);

        }

        public void JavaScriptValue(IWebDriver driver, String value, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].value='" + value + "'", element);

        }

        public void JavaScripButtonClick(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click()", element);

        }
        public IWebElement FindElByname(IWebDriver driver, String name)
        {
            return driver.FindElement(By.XPath("//input[@name='" + name + "']"));
        }
        public IWebElement FindElById(IWebDriver driver, String id)
        {
            return driver.FindElement(By.Id(id));
        }
    
}
}
