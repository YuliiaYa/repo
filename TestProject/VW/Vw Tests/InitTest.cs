using System;
using OpenQA.Selenium;
using NUnit.Framework;
using TestProject.VW.Unit;

namespace TestProject.Vw_Tests
{
    [TestFixture]
    public class InitTest
    {
        protected IWebDriver driver;
        //protected string qaBaseURL;

        [SetUp]
        public void SetUp() 
        {
            driver = new DriverSetUp("ChromeWindows").GetDriver();
           // qaBaseURL = "https://volkswagen.adzu4-qa-web.adzu.codeworldwide.com/#";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
          //   driver.Manage().Window.Maximize();
        }
       // [TearDown]
       // public void TearDown()
       // {
       //     driver.Quit();
      //  }

    }
}
