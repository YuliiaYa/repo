using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject.VW.Vw_Pages
{
    class VwmanageFormPage
    {
      private IWebDriver driver;
      private VwmanageFormPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public readonly By formStatusFieldLoc = By.CssSelector("//table[@class='table table-bordered table-striped']/tbody/tr[6]/td[3]");

        public bool ISFormPublished() {
            driver.Navigate().GoToUrl("https://volkswagen.adzu4-qa-web.adzu.codeworldwide.com/#Admin/RequestForm");
           
                if (driver.FindElement(formStatusFieldLoc).Text == "Published")
                    return true;
                else
                    return false;
         //   driver.Navigate().GoToUrl("https://volkswagen.adzu4-qa-web.adzu.codeworldwide.com/#Admin/RequestFo6rm");

        }

              

}
}
