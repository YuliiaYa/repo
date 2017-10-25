using NUnit.Framework;
using TestProject.Vw_Tests;
using TestProject.VW.Vw_Pages;
using TestProject.VW.TestData;


namespace TestProject.VW.Vw_Tests
{
    [TestFixture]
    public class ClickCampaignsTile : InitTest
    {
        
        [Test]
        public void OpenCampaignPage()
        {
            VwLoginPage loginPage = new VwLoginPage(driver);
            VwHomePage homePage = new VwHomePage(driver);
            VwCampaignPage campaignPage = new VwCampaignPage(driver);

            loginPage.Login(VwLoginDataQa.centralMarketCorrectLogin, VwLoginDataQa.centralMarketCorrectPassword);
            homePage.ClickOnCampaignFromHomePage(VwCampaignData.numberOfTesingCampaign);
            WaitTillPageLoad(10.00);

            Assert.AreEqual(VwCampaignData.campaignName, driver.FindElement(campaignPage.campaignsNameLoc).Text);
            Assert.AreEqual(VwSiteUrls.vWDomenQa + VwSiteUrls.campaignsPageUrl + "/VolkswagenTuareg", driver.Url);
        }
    }
}
