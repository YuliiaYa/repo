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
        public readonly By userNameLoc = By.XPath("//span[@class='user-name']");
        public readonly By homeTabLoc = By.XPath("//*[@class='nav navbar-nav']/li[1]");
        public readonly By campaignsTabLoc = By.XPath("//*[@class='nav navbar-nav']/li[2]");
        public readonly By adminTabLoc = By.XPath("//*[@class='nav navbar-nav']/li[3]");
        //      Assert that header menu is active;

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
        public VwHeader GetTabColor()
        {
            //    IWebElement campaignsTab = driver.FindElement(campaignsTabLoc);
            //    string buttonTextColor = campaignsTab.GetCssValue("color");
            //    return this;
            //}
              string campaignsTabColor = driver.FindElement(By.XPath(".//*[@id='body']/div[2]/div/div/div/div/nav/div[3]/ul/li[2]")).GetCssValue("color");;
          //  string campaignsTabColor = driver.FindElement(By.XPath("//*[@class='nav navbar-nav']/li[2]")).GetCssValue("color");
            return this;
        }
//.//*[@id='body']/div[2]/div/div/div/div/nav/div[3]/ul/li[2]
        //*[@class='nav navbar-nav']/l
            public bool IsUserNameDisplayed(IWebDriver driver, By userNameLoc)
        {
            if (driver.FindElement(userNameLoc).Displayed)
                return true;
            else
                return false;
        }

            public bool IsNavigationForCentralMarketDisplayed() {
                try
                {
                    driver.FindElement(adminTabLoc) ;
                    driver.FindElement(campaignsTabLoc);
                    driver.FindElement(adminTabLoc);
            return true;
        }
            catch (NoSuchElementException e)
            {
                return false; 
            }
        }
    }
}
