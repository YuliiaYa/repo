using System;
using NUnit.Framework;
using TestProject.Vw_Tests;
using TestProject.VW.Vw_Pages;
using TestProject.VW.TestData;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace TestProject.VW.Vw_Tests

{
    class OpenContentRequestForm
    {
        [TestFixture]
        public class GoToCampaignPage : InitTest
        {
            public GoToCampaignPage(): base() {
                this.siteURL = "https://volkswagen.adzu4-qa-web.adzu.codeworldwide.com/#RequestForm/Executions/6f5ab54c-446d-eb48-87e4-39e140d42aed";
            }
            [Test]
           
            public void OpenContentRequestFormAsCentralMarketUser()
            {
                VwLoginPage loginPage = new VwLoginPage(driver);
                VwContentRequestForm crf = new VwContentRequestForm(driver);

                loginPage.Login(VwLoginDataQa.centralMarketCorrectLogin, VwLoginDataQa.centralMarketCorrectPassword);
                WaitTillPageLoad(15.00);

    
                 Assert.True(crf.IsButtonDisplayed(crf.bulkUploadButtonLoc));
                 Assert.True(crf.IsButtonDisplayed(crf.addExecutionButtonLoc));
                 Assert.AreEqual(VwSiteUrls.vWDomenQa + VwSiteUrls.contentRequestPageUrl+VwSiteUrls.executionHash, driver.Url);
                 Assert.AreEqual(VwContentRequestFormData.formNameForCentralMarketUser + " > " + VwCampaignData.campaignName,
                 driver.FindElement(crf.breadCrumpLinkLoc).Text);

                Console.WriteLine(driver.FindElement(crf.breadCrumpLinkLoc).Text);
            }
        }
    }
}
