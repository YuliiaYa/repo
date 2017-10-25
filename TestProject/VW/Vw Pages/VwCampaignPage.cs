using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject.VW.Vw_Pages
{
        class VwCampaignPage : VwHomePage
    {
        public VwCampaignPage(IWebDriver driver) : base(driver)
        {
        }

        public readonly By campaignsNameLoc = By.XPath(".//*[@class='col-sm-12']/nest[@type='Text']");
        public readonly By contentRequestFormLoc = By.XPath("//*[text()='Content Request Form']");
        public readonly By campaignStrategyDocumentLoc = By.XPath("//*[text()='View The Campaign Strategy Document']");


        public VwCampaignPage ClickOnContentRequestForm()
        {
                IWebElement contentRequestForm= driver.FindElement(contentRequestFormLoc);
                contentRequestForm.Click();
                return this;
        }
        public VwCampaignPage ClickOnCampaignStrategyDocument()
        {
            IWebElement campaignStrategyDocument = driver.FindElement(campaignStrategyDocumentLoc);
            campaignStrategyDocument.Click();
            return this;
        }


    }

    }

