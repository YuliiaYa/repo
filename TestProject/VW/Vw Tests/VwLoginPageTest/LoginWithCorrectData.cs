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
    [TenantId("DP")]
    [TestFixture]
    public class CorrectLoginData : InitTest
    {
    
        [Test]
        public void LoginWithCorrectDataCentralMarket()
        {
            VwLoginPage loginPage = new VwLoginPage(driver);
            VwHeader header = new VwHeader(driver);

            loginPage.Login(VwLoginDataQa.centralMarketCorrectLogin, VwLoginDataQa.centralMarketCorrectPassword);
            WaitTillPageLoad(15.00);

            Assert.AreEqual("rgba(1, 168, 236, 1)", driver.FindElement(By.XPath("//*[@class='nav navbar-nav']/li[1]/a")).GetCssValue("color"));
            Assert.IsTrue(header.IsUserNameDisplayed(header.userNameLoc));
             Assert.AreEqual(VwLoginDataQa.centralMarketName, driver.FindElement(header.userNameLoc).Text);
            // Assert.True(header.IsNavigationForCentralMarketDisplayed(header.adminTabLoc, header.homeTabLoc, header.campaignsTabLoc));
        }

        [Test]
        public void LoginWithCorrectDataLocalMarket()
        {
            VwLoginPage loginPage = new VwLoginPage(driver);
            VwHeader header = new VwHeader(driver);

            loginPage.Login(VwLoginDataQa.localMarketCorrectLogin, VwLoginDataQa.localMarketCorrectPassword);
            WaitTillPageLoad(15.00);


            Assert.AreEqual("rgba(1, 168, 236, 1)", driver.FindElement(By.XPath("//*[@class='nav navbar-nav']/li[1]/a")).GetCssValue("color")); 
            Assert.True(header.IsUserNameDisplayed(header.userNameLoc));
           //  Assert.AreEqual(VwLoginDataQa.localMarketName, driver.FindElement(header.userNameLoc).Text);
            Console.WriteLine(driver.FindElement(header.userNameLoc).Text);
            //  Assert.False(header.IsNavigationForCentralMarketDisplayed(header.adminTabLoc, header.homeTabLoc, header.campaignsTabLoc)); 30s can not optimize
        }
    }
}
