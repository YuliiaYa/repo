using TestProject.Vw_Tests;
using TestProject.VW.Vw_Pages;
using TestProject.VW.TestData;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace TestProject.VW.Vw_Tests
{
    [TestFixture]
    public class IncorrectLoginData : InitTest
    {
        [RetryFail]
        [Test]
        public void LoginWithIncorrectDataCentralMarket()
        {
            VwLoginPage loginPage = new VwLoginPage(driver);
            loginPage.Login(VwLoginDataQa.centralMarketCorrectLogin+1, VwLoginDataQa.centralMarketCorrectPassword);
            WaitTillPageLoad(10.00);

            Assert.IsTrue(loginPage.IsLoginFormDisplayed(driver, loginPage.loginFieldLoc));
            Assert.IsTrue(loginPage.IsErrorMessageDisplayed(driver, loginPage.errorMessageLoc));
            Assert.AreEqual("Error: Invalid username or password", driver.FindElement(loginPage.errorMessageLoc).Text);

        }
    }

}
