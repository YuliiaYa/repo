using TestProject.Vw_Tests;
using TestProject.VW.Vw_Pages;
using TestProject.VW.TestData;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace TestProject.VW.Vw_Pages
{
    class VwContentRequestForm :VwHomePage
    {
        public VwContentRequestForm(IWebDriver driver) : base(driver)
        {
        }

        public readonly By addExecutionButtonLoc = By.XPath("//div[@class = 'pull-right']/button[2]");
        public readonly By bulkUploadButtonLoc = By.XPath("//*[@class='btn btn-default'][1]");
        public readonly By countOfExecutionLoc = By.XPath("//input[@id='pa1']");
        public readonly By breadCrumpLinkLoc = By.XPath("//*[@class='nav-content']");
        public readonly By breadCrumpTextLoc = By.XPath(".//*[@class='nav-content']");

        public readonly By selectCampaignPhaseLoc = By.XPath("//div[@class = 'modal-backdrop fade in']/[2]");
        public readonly By selectContentElementNameLoc = By.XPath("//div[@class = 'pull-right']/button[2]");
        public readonly By contentElementDescriptionLoc = By.XPath("//div[@class = 'pull-right']/button[2]");
        public readonly By formatTypeLoc = By.XPath("//div[@class = 'pull-right']/button[2]");
        public readonly By durationLoc = By.XPath("//div[@class = 'pull-right']/button[2]");
        public readonly By communicationObjectiveLoc = By.XPath("//div[@class = 'pull-right']/button[2]");
        public readonly By audienceSegmentsLoc = By.XPath("//div[@class = 'pull-right']/button[2]");
        public readonly By specificKpiLoc = By.XPath("//div[@class = 'pull-right']/button[2]");
        public readonly By firstTimeOnAirLoc = By.XPath("//div[@class = 'pull-right']/button[2]");
        public readonly By usageEndDateLoc = By.XPath("//div[@class = 'pull-right']/button[2]");
        public readonly By addDefaultCommentLoc = By.XPath("//div[@class = 'pull-right']/button[2]");
        public readonly By whoWillProduceLoc = By.XPath("//div[@class = 'pull-right']/button[2]");



        public VwContentRequestForm ClickAddExecution()
        {
            IWebElement addExecutionButton = driver.FindElement(addExecutionButtonLoc);
            addExecutionButton.Click();
            return this;

        }
        public bool IsButtonDisplayed(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }


       



    }
}


