using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace TestProject.VW.Vw_Pages
{
    class VwCampaignsPage : VwHomePage
    {

        public VwCampaignsPage(IWebDriver driver) : base(driver)
        {
        }
        public readonly By campaignsListCampaignPageLoc = By.XPath("//*[@class='col-sm-3']");
        public static readonly String campaignsPageLink = "https://volkswagen.adzu4-qa-web.adzu.codeworldwide.com/#page/Campaigns";

        public VwCampaignsPage ClickViewMoreCampaignsButton()
        {
            IWebElement viewMoreCampaignsButton = driver.FindElement(viewMoreCampaignsLoc);
            viewMoreCampaignsButton.Click();
            return this;
        }

        public IList<IWebElement> GetCampaignsListFromCampaignsPage()
        {

            return driver.FindElements(campaignsListCampaignPageLoc);
        }

        public void ClickOnCampaignFromcampaignPage(int number)
        {
            GetCampaignsListFromCampaignsPage()[number].Click();
        }
    }
}
