using System;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject.Vw_Tests;
using TestProject.VW.Vw_Pages;
using TestProject.VW.TestData;

namespace TestProject.VW.Vw_Tests
{
    [TestFixture]
    public class ViewMoreCampaigns : InitTest
    {
        // public static String login="aaa";
        // public String login = "aaa";
        // protected String login = "adzu4@codeworldwide.com";


        [Test]
        public void ClickViewMoreCampaignsButton()
        {
            VwLoginPage loginPage = new VwLoginPage(driver);
            VwHomePage homePage = new VwHomePage(driver);
            loginPage.OpenLoginPage();
            loginPage.EnterLogin(VwLoginDataQa.centralMarketCorrectLogin);
            loginPage.EnterPassword(VwLoginDataQa.centralMarketCorrectPassword);
            loginPage.SubmitLogin();
            homePage.ClickViewMoreCampaigns();
        }

    }
}
