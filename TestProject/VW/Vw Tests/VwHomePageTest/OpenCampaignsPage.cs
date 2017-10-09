using System;
///using NUnit.Framework;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject.Vw_Tests;
using TestProject.VW.Vw_Pages;
using TestProject.VW.TestData;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace TestProject.VW.Vw_Tests.VwHomePageTest
{
    [TestFixture]
    public class OpenCampaignsPage : InitTest
    {
        [Test]
        [RetryFail]
        public void GoToCampaignsPage()
        {
            VwLoginPage loginPage = new VwLoginPage(driver);
            VwHomePage homePage = new VwHomePage(driver);
            VwHeader header = new VwHeader(driver);
            loginPage.Login(VwLoginDataQa.centralMarketCorrectLogin, VwLoginDataQa.centralMarketCorrectPassword);


            header.ClickCampaignTab();
       
             WaitTillPageLoad(15.00);

            Assert.AreEqual(VwSiteUrls.vWDomenQa+VwSiteUrls.campaignsPageUrl , driver.Url);
            Assert.AreEqual("rgba(1, 168, 236, 1)", driver.FindElement(By.XPath("//*[@class='nav navbar-nav']/li[2]/a")).GetCssValue("color"));
           

        }

    }
}
