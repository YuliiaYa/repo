using System;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject.Vw_Tests;
using TestProject.VW.Vw_Pages;
using TestProject.VW.TestData;

namespace TestProject.VW.Vw_Tests.VwCampaignPage
{
    class OpenContentRequestForm
    {
        [TestFixture]
        public class GoToCampaignPage : InitTest
        {
            [Test]
            public void clickOnContentRequestForm()
            {
                VwLoginPage loginPage = new VwLoginPage(driver);
                VwHomePage homePage = new VwHomePage(driver);
                VwHeader header = new VwHeader(driver);

                loginPage.OpenLoginPage();
                loginPage.EnterLogin(VwLoginDataQa.centralMarketCorrectLogin);
                loginPage.EnterPassword(VwLoginDataQa.centralMarketCorrectPassword);
                loginPage.SubmitLogin();

            
            }
        }
    }
}
