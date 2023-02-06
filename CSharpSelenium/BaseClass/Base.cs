using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpSelenium.Util;
using CSharpSelenium.POM;
using System.Security.Authentication.ExtendedProtection;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

namespace CSharpSelenium.BaseClass
{
    public class Base
    {
        public IWebDriver driver;
        public WebDriverUtil W_lib = new WebDriverUtil();
       public  ExtentReports extent;
       public  ExtentTest test;
        [OneTimeSetUp]
        public void OpenBrowser()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:8888/");

            W_lib.implicityWaites(driver, 15);

             extent=new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\yusuf\source\repos\CSharpSelenium\CSharpSelenium\ER\demo.html");
            extent.AttachReporter(htmlReporter);
            test = extent.CreateTest("OpenBrowser").Info("OpenBrowser");
            test.Log(Status.Info, "OpenBrowser");
        }
        [SetUp]
        public void loin()
        {
            test =extent.CreateTest("loin").Info("log in to application");
            Console.WriteLine("login to the app");
            LogInPage lg = new LogInPage(driver);
            lg.SetLogIn("admin", "admin");

        }
        //[TearDown]
        //public void logout()
        //{
        //    HomePage hp = new HomePage(driver);   
        //    W_lib.ActionMouseHover(driver,hp.GetAdministrator( ));
        //    hp.GetSignOut().Click();

        //    Console.WriteLine("log out ");

        //}
        [OneTimeTearDown]

        public void CloseBrowser()
        {
            test = extent.CreateTest("CloseBrowse").Info("CloseBrowse");
           
            extent.Flush();
            Console.WriteLine("close broser");
          //  driver.Quit();

        }
    }
}
