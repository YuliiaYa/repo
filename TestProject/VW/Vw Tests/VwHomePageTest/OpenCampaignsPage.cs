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
        public void GoToCampaignsPage()
        {
            VwLoginPage loginPage = new VwLoginPage(driver);
            VwHomePage homePage = new VwHomePage(driver);
            VwHeader header = new VwHeader(driver);

            loginPage.OpenLoginPage();
            loginPage.EnterLogin(VwLoginDataQa.centralMarketCorrectLogin);
            loginPage.EnterPassword(VwLoginDataQa.centralMarketCorrectPassword);
            loginPage.SubmitLogin();

            header.ClickCampaignTab();
       
             WaitTillPageLoad(10.00);
            //assert that campaigns is blue
            // Assert.AreEqual(VwSiteUrls.vWDomenQa+VwSiteUrls.campaignsPageUrl , driver.Url);
          //   Assert.AreEqual("rgb(1, 168, 236)",header.GetTabColor() );
            // string color = header.campaignsTabLoc.GetCssValue("color");
            // driver.FindElement(By.Name("submit")).GetCssValue("background-color");
            //  string campaignsTabColor = driver.FindElement(By.XPath("//*[@class='nav navbar-nav']/li[2]")).GetCssValue("color");
           // Console.WriteLine(driver.FindElement(By.XPath("//*[@class='nav navbar-nav']/li[2]")).GetCssValue("color"));

            Console.WriteLine(driver.FindElement(By.XPath(".//*[@id='body']/div[2]/div/div/div/div/nav/div[3]/ul/li[2]")).GetCssValue("color"));
          //  Console.WriteLine(driver.FindElement(By.XPath("//*[@class='nav navbar-nav']/li[2]")).GetCssValue("color"));
           // Console.WriteLine(driver.FindElement(By.XPath("//*[@class='nav navbar-nav']/li[3]")).GetCssValue("color"));

        }

    }
}
