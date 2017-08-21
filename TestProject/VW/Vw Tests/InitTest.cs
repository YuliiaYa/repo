using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using NUnit.Framework;
using TestProject.VW.Unit;

namespace TestProject.Vw_Tests
{
    [TestFixture]
    public class InitTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp() 
        {
            driver = new DriverSetUp("ChromeWindows").GetDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
