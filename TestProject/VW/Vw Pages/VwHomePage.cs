using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestProject.VW.TestData;

namespace TestProject.VW.Vw_Pages
{
    class VwHomePage
    {
        public IWebDriver driver;
        public VwHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public readonly By campaignsTitleLoc = By.XPath("//*[@class='col-sm-12']//*[text()='Campaigns']");
        public readonly By campaignsListHomePageLoc = By.XPath("//*[@class='col-sm-4']");
        private readonly By viewMoreCampaignsLoc = By.XPath("//button[@class='btn btn-default']");

        
        public VwHomePage ClickViewMoreCampaigns()
        {
                IWebElement viewMoreCampaignsButton = driver.FindElement(viewMoreCampaignsLoc);
                viewMoreCampaignsButton.Click();
                return this;
        }
        
        public IList<IWebElement> GetCampaigns() {

            return driver.FindElements(campaignsListHomePageLoc);
        }

        public void ClickOnCampaign(int number)
        {
           GetCampaigns()[number].Click();
        }

    }
}
