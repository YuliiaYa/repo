using System;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            
            loginPage.OpenLoginPage();
            loginPage.EnterLogin(VwLoginDataQa.centralMarketCorrectLogin);
            loginPage.EnterPassword(VwLoginDataQa.centralMarketCorrectPassword);
            loginPage.SubmitLogin();
            homePage.ClickOnCampaign(VwCampaignData.campaignNumber);

            //Assert.AreEqual("Error: Invalid username or password", driver.FindElement().Text);
        }
    }
}
