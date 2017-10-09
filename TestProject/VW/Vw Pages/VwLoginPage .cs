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
      //  public readonly By submitButtonLoc = By.XPath("//button[@type='button'][text()='Login']");
        public readonly By loginFormLoc = By.XPath("//*[@class='modal-content']");
        public readonly By errorMessageLoc = By.XPath("//div[@class='alert alert-danger']");
        public readonly By submitButtonLoc = By.XPath("//button[@class='btn btn-primary login pull-right']");
     

     //   public VwLoginPage OpenLoginPage()
      //  {
      //      driver.Navigate().GoToUrl("https://volkswagen.adzu4-qa-web.adzu.codeworldwide.com/#");
     //       return new VwLoginPage(driver);
      //  }

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
            submitButton.Submit();
        }




        public VwLoginPage EnterLogin(String Login)
        {
            try
            {
                IWebElement loginField = driver.FindElement(loginFieldLoc);
                loginField.SendKeys(Login);
            }
            catch (StaleElementReferenceException e)
            {
                EnterLogin(Login);
            }
            return this;
        }

        public VwLoginPage EnterPassword(String Password)
        {
            IWebElement passwordField = driver.FindElement(userPasswordLoc);
            passwordField.SendKeys(Password);
            return this;
        }

        public void SubmitLogin()
        {
            IWebElement submitButton = driver.FindElement(submitButtonLoc);
            submitButton.Submit();
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

