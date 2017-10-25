using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace TestProject.Vw_Tests
{
    class VwLoginPage
    {
        private IWebDriver driver;
        public VwLoginPage(IWebDriver driver) {
            this.driver = driver;
        }

        public readonly By loginFieldLoc = By.XPath("//input[@id='us1']");
        public readonly By userPasswordLoc = By.XPath("//input[@id='pa1']");
        public readonly By loginFormLoc = By.XPath("//*[@class='modal-content']");
        public readonly By errorMessageLoc = By.XPath("//*[@class='alert alert-danger']");
        public readonly By submitButtonLoc = By.XPath("//*[@class='btn btn-primary login pull-right']");
     
        public void Login(string username, string password)
        {
            IWebElement loginField = driver.FindElement(loginFieldLoc);
            IWebElement passwordField = driver.FindElement(userPasswordLoc);
            IWebElement submitButton = driver.FindElement(submitButtonLoc);

            loginField.Clear();
            loginField.SendKeys(username);
            passwordField.Clear();
            passwordField.SendKeys(password);
            submitButton.Click();
          
        }

        public bool IsLoginFormDisplayed(IWebDriver driver, By loginFormLoc)
        {
            if (driver.FindElement(loginFormLoc).Displayed)
                return true;
            else
                return false;
        }
             public bool IsErrorMessageDisplayed(IWebDriver driver, By errorMessageLoc)
        {
            if (driver.FindElement(errorMessageLoc).Displayed)
                return true;
            else
                return false;
        }




    }
}

