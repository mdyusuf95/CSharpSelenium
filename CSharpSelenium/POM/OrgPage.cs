using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.POM
{
    public  class OrgPage
    {

        [FindsBy(How = How.XPath, Using = "//img[@title='Create Organization...']")]
        private IWebElement ceratOrg { get; set; }

        [FindsBy(How=How.XPath,Using= "//div/table[@class='lvt small']/tbody/tr[@id='row_178']/td/a")]
        public IWebElement orgname { get; set; }

        public OrgPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

        }

        public IWebElement GetCeratOrg()
        {
            return this.ceratOrg;
        }

        public IWebElement GetOrgnmae()
        {
            return this.orgname;
        }

    }
}
