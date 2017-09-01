using TestProject.Vw_Tests;
using TestProject.VW.Vw_Pages;
using TestProject.VW.TestData;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace TestProject.VW.Vw_Tests
{
    [TestFixture]
    public class CorrectLoginData : InitTest
    {
        [Test]
        public void LoginWithCorrectDataCentralMarket()
        {
            VwLoginPage loginPage = new VwLoginPage(driver);
            VwHeader header = new VwHeader(driver);

            loginPage.OpenLoginPage();
            loginPage.EnterLogin(VwLoginDataQa.centralMarketCorrectLogin);
            loginPage.EnterPassword(VwLoginDataQa.centralMarketCorrectPassword);
            loginPage.SubmitLogin();
            WaitTillPageLoad(10.00);

            Assert.False(loginPage.IsLoginFormDisplayed(driver, loginPage.loginFieldLoc));
            Assert.IsTrue(header.IsUserNameDisplayed(driver, header.userNameLoc));
            Assert.AreEqual(VwLoginDataQa.centralMarketName, driver.FindElement(header.userNameLoc).GetAttribute("textContent"));
            Assert.True(header.IsNavigationForCentralMarketDisplayed());
        }

        [Test]
        public void LoginWithCorrectDataLocalMarket()
        {
            VwLoginPage loginPage = new VwLoginPage(driver);
            VwHeader header = new VwHeader(driver);

            loginPage.OpenLoginPage();
            loginPage.EnterLogin(VwLoginDataQa.localMarketCorrectLogin);
            loginPage.EnterPassword(VwLoginDataQa.localMarketCorrectPassword);
            loginPage.SubmitLogin();
            WaitTillPageLoad(15.00);

            Assert.False(loginPage.IsLoginFormDisplayed(driver, loginPage.loginFieldLoc));
            Assert.IsTrue(header.IsUserNameDisplayed(driver, header.userNameLoc));
            Assert.AreEqual(VwLoginDataQa.localMarketName, driver.FindElement(header.userNameLoc).GetAttribute("textContent"));

            //add assert  IsNavigationForLocallMarketDisplayed());
        }    
    }
}
