
using CSharpSelenium.BaseClass;
using CSharpSelenium.POM;
using NUnit.Framework;
using OpenQA.Selenium.DevTools.V107.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpSelenium.Test
{
    public class CreateOrgTestbase:Base
    {
        [Test]
        [TestCase("moin")]
        public void testing(String Orgname )
        {

            HomePage hp = new HomePage(driver);
            hp.GetOrganizations().Click();
            OrgPage or = new OrgPage(driver);
            or.GetCeratOrg().Click();
            CreatingNewOrganization nor = new CreatingNewOrganization(driver);
            nor.GetOrganizationNameg().SendKeys(Orgname);
           // nor.Getwebsite().SendKeys(mail);
            nor.GetSvaeButton().Click();
            Thread.Sleep(1000);
            Console.WriteLine("orgnisation created");
            driver.Quit();
            
        }
        //[Test,Category("Regression Testing")]
        //public void testing1()
        //{

        //    HomePage hp = new HomePage(driver);
        //    hp.GetOrganizations().Click();
        //    OrgPage or = new OrgPage(driver);
        //    or.GetCeratOrg().Click();
        //    CreatingNewOrganization nor = new CreatingNewOrganization(driver);
        //    nor.GetOrganizationNameg().SendKeys("aslacompany123");
        //    nor.Getwebsite().SendKeys("aslacompany.com");
        //    nor.GetSvaeButton().Click();
        //    Thread.Sleep(1000);
        //    Console.WriteLine("orgnisation created");

        //}
        //[Test,Category("smoke Testing")]
        //public void testing2()
        //{

        //    HomePage hp = new HomePage(driver);
        //    hp.GetOrganizations().Click();
        //    OrgPage or = new OrgPage(driver);
        //    or.GetCeratOrg().Click();
        //    CreatingNewOrganization nor = new CreatingNewOrganization(driver);
        //    nor.GetOrganizationNameg().SendKeys("aslacompany123");
        //    nor.Getwebsite().SendKeys("aslacompany.com");
        //    nor.GetSvaeButton().Click();
        //    Thread.Sleep(1000);
        //    Console.WriteLine("orgnisation created");

        //}
         static Object[] DataProvider()

        {

            Object[] ar = new object[2];
            ar[0] = "saruntrades";
            ar[1] = "mohankumar";

           

              return ar;


        }
    }
}
