using NUnit.Framework;
using TestProject.Vw_Tests;
using TestProject.VW.Vw_Pages;
using TestProject.VW.TestData;
using System;

namespace TestProject.VW.Vw_Tests
{
    [TestFixture]
    public class ViewMoreCampaigns : InitTest
    {

        [Test]
        [RetryFail]
        public void ClickViewMoreCampaignsButtonHomePage()
        {
            VwLoginPage loginPage = new VwLoginPage(driver);
            VwHomePage homePage = new VwHomePage(driver);

            loginPage.Login(VwLoginDataQa.centralMarketCorrectLogin, VwLoginDataQa.centralMarketCorrectPassword);
            homePage.ClickViewMoreCampaigns();
            homePage.GetCampaignsListFromHomePage();
            WaitTillPageLoad(5.00);

            Assert.AreEqual(VwCampaignData.defaultCountOfTilesHomePage+VwCampaignData.countOfTilesInOneRow, homePage.GetCampaignsListFromHomePage().Count);
        }

     //   [Test]
        [RetryFail]
        public void ClickViewMoreCampaignsButtonCampaignPage()
        {
            VwLoginPage loginPage = new VwLoginPage(driver);
            VwHomePage homePage = new VwHomePage(driver);
            VwHeader header = new VwHeader(driver);
            VwCampaignsPage campaignsPage = new VwCampaignsPage(driver);

            loginPage.Login(VwLoginDataQa.centralMarketCorrectLogin, VwLoginDataQa.centralMarketCorrectPassword);
            header.ClickCampaignTab();
            WaitTillPageLoad(15.00);
            homePage.ClickViewMoreCampaigns();
            campaignsPage.GetCampaignsListFromCampaignsPage();
            WaitTillPageLoad(15.00);
            Assert.AreEqual(VwCampaignData.defaultCountOfTilesCampaignPage + 2, campaignsPage.GetCampaignsListFromCampaignsPage().Count);
        }

    }
}
