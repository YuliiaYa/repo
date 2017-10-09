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
        //public IWebDriver driver;
        //public VwContentRequestForm(IWebDriver driver)
        //{
        //    this.driver = driver;
        //}
        public VwContentRequestForm(IWebDriver driver) : base(driver)
        {
        }

        public readonly By addExecutionButtonLoc = By.XPath("//div[@class = 'pull-right']/button[2]");
        public readonly By bulkUploadButtonLoc = By.XPath("//*[@class='btn btn-default'][1]");
        //
        ////*[@class='btn btn-primary'][2]
        public readonly By countOfExecutionLoc = By.XPath("//input[@id='pa1']");
        public readonly By breadCrumpLoc = By.XPath("//*[@class='adzu-plugins-asset-management-nav-bar']/span");

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


