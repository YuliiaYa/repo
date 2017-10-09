using System;
using NUnit.Framework;
using TestProject.Vw_Tests;
using TestProject.VW.Vw_Pages;
using TestProject.VW.TestData;
using TestProject.VW.Enums;
using OpenQA.Selenium;


namespace TestProject.VW.Vw_Tests
{
    [TestFixture]
    public class ClickCampaignsTile : InitTest
    {
        
        [Test]
        //[RetryFail]
        public void OpenCampaignPage()
        {
            VwLoginPage loginPage = new VwLoginPage(driver);
            VwHomePage homePage = new VwHomePage(driver);
            VwCampaignPage campaignPage = new VwCampaignPage(driver);

            loginPage.Login(VwLoginDataQa.centralMarketCorrectLogin, VwLoginDataQa.centralMarketCorrectPassword);
           
            homePage.ClickOnCampaignFromHomePage(2);
             WaitTillPageLoad(15.00);

            
          // Assert.AreEqual(VwCampaignData.campaignName, driver.FindElement(campaignPage.campaignsNameLoc).Text);
            Assert.AreEqual(VwSiteUrls.vWDomenQa + VwSiteUrls.campaignsPageUrl + "/VolkswagenTuareg", driver.Url);
            Console.WriteLine(driver.FindElement(campaignPage.campaignsNameLoc).Text);

        }
    }
}
