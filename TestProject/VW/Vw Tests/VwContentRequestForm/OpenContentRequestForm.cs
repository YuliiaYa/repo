using System;
using NUnit.Framework;
using TestProject.Vw_Tests;
using TestProject.VW.Vw_Pages;
using TestProject.VW.TestData;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
namespace TestProject.VW.Vw_Tests.VwCampaignPageTests

{
    class OpenContentRequestForm
    {
        [TestFixture]
        public class GoToCampaignPage : InitTest
        {
            [Test]
            [RetryFail]
            public void СlickOnContentRequestForm()
            {
            
                VwLoginPage loginPage = new VwLoginPage(driver);
                VwHomePage homePage = new VwHomePage(driver);
                VwHeader header = new VwHeader(driver);
                VwCampaignPage campaignPage = new VwCampaignPage(driver);
                VwContentRequestForm crf = new VwContentRequestForm(driver);

                loginPage.Login(VwLoginDataQa.centralMarketCorrectLogin, VwLoginDataQa.centralMarketCorrectPassword);
                homePage.ClickOnCampaignFromHomePage(VwCampaignData.campaignNumber);
                campaignPage.ClickOnContentRequestForm();

                WaitTillPageLoad(15.00);
      
                 Assert.True(crf.IsButtonDisplayed(crf.bulkUploadButtonLoc));
                 Assert.True(crf.IsButtonDisplayed(crf.addExecutionButtonLoc));
                 Assert.AreEqual(VwSiteUrls.vWDomenQa + VwSiteUrls.contentRequestPageUrl+VwSiteUrls.executionHash, driver.Url);

                 WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                 wait.Until(d => d.FindElement(crf.breadCrumpLoc)).Text.Contains("Manage Content Request Forms");

                Assert.AreEqual(VwContentRequestFormData.formNameForCentralMarketUser + " > " + VwCampaignData.campaignName,
                 driver.FindElement(crf.breadCrumpLoc).Text);

                //   Console.WriteLine(VwContentRequestFormData.formNameForCentralMarketUser + " > " + VwCampaignData.campaignName);
                 

               // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                //wait.Until(d => d.FindElement(crf.breadCrumpLoc)).Text.Contains("Manage Content Request Forms");
               // Console.WriteLine(driver.FindElement(crf.breadCrumpLoc).Text);


                //  Assert.AreEqual(VwLoginDataQa.localMarketName, driver.FindElement(header.userNameLoc).Text);

            }
        }
    }
}
