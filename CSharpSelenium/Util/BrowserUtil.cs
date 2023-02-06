using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.Util
{
    public  class BrowserUtil
    {

        public IWebDriver init(IWebDriver driver)

        {


            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:8888/");
            WebDriverUtil W_lib = new WebDriverUtil();
            W_lib.implicityWaites(driver, 15);
            return driver;
        }
    }
} 
