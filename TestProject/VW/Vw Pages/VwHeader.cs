using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProject.VW.Vw_Pages
{
    class VwHeader
    {
        public IWebDriver driver;
        public VwHeader(IWebDriver driver)
        {
            this.driver = driver;
        }
        public readonly By headerImageLoc = By.XPath("//*[@class='volkswagen-logo']");
        public readonly By userNameLoc = By.XPath(".//*[@class='dropdown-toggle']/span");
        public readonly By homeTabLoc = By.XPath("//*[@class='nav navbar-nav']/li[1]");
        public readonly By campaignsTabLoc = By.XPath("//*[@class='nav navbar-nav']/li[2]/a");
        public readonly By adminTabLoc = By.XPath("//*[@class='nav navbar-nav']/li[3]");

        public VwHeader ClickHomeTab()
        {
            IWebElement homeTab = driver.FindElement(homeTabLoc);
            homeTab.Click();
            return this;
        }
        public VwHeader ClickCampaignTab()
        {
            IWebElement campaignsTab = driver.FindElement(campaignsTabLoc);
            campaignsTab.Click();
            return this;
        }
        public VwHeader ClickAdminTab()
        {
            IWebElement adminTab = driver.FindElement(adminTabLoc);
            adminTab.Click();
            return this;
        }
    //    public VwHeader GetTabColor(IWebElement element)
     //   {
              //  IWebElement campaignsTab = driver.FindElement(campaignsTabLoc);
        //       string buttonTextColor = element.GetCssValue("color");
         //       return this;
        //    }












            public bool IsUserNameDisplayed( By by)
        {
            if (driver.FindElement(by).Displayed)
                return true;
            else
                return false;
        }

            public bool IsNavigationForCentralMarketDisplayed(By element1, By element2, By element3) {
                try
                {
                    driver.FindElement(element1) ;
                    driver.FindElement(element2);
                    driver.FindElement(element3);
            return true;
        }
            catch (NoSuchElementException e)
            {
                return false; 
            }
        }
    }
}
