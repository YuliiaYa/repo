using System;
using OpenQA.Selenium;
using NUnit.Framework;
using TestProject.VW.Unit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;

namespace TestProject.Vw_Tests
{
    [TestFixture]
    public class InitTest
    {
        protected IWebDriver driver;
        public  String siteURL = VW.TestData.VwSiteUrls.vWDomenQa;

        [SetUp]
        public void SetUp()
        {
            driver = new DriverSetUp("ChromeWindows").GetDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl(siteURL);
            WaitTillPageLoad(15.00);
        }

        [TestMethod]
        protected void WaitTillPageLoad(double seconds)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return  $.active == 0").Equals(true));
            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }
      
        


        [TearDown]
        protected void TearDown()
        {
             //driver.Quit();
        }
    }
}
