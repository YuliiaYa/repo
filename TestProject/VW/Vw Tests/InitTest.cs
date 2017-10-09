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
        protected String siteURL = "https://volkswagen.adzu4-qa-web.adzu.codeworldwide.com/#";

        [SetUp]
        protected void SetUp()
        {
            driver = new DriverSetUp("ChromeWindows").GetDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl(siteURL);
        }

        [TestMethod]
        protected void WaitTillPageLoad(double seconds)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return  $.active == 0").Equals(true));
            wait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }
        


        [TearDown]
        protected void TearDown()
        {
            // driver.Quit();
        }
    }
}
