using System;
using System;
using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;


namespace TestProject.VW.Vw_Pages
{
    class VwLoginPage 
    {
        public IWebDriver driver;
        public String qaBaseURL;

        public readonly By userNameLoc = By.XPath("//input[@id='us1']");
        public readonly By userPasswordLoc = By.XPath("//input[@id='pa1']");
        public readonly By submitButtonLoc = By.XPath("//button[@type='button'][text()='Login']");

        public VwLoginPage(IWebDriver driver) { }

        public VwLoginPage OpenLoginPage(string qaBaseURL)
        {
            driver.Navigate().GoToUrl(qaBaseURL);
            return new VwLoginPage(driver);
        }




    }
}

        //public VwLoginPage(IWebDriver driver) { }

        //public VwLoginPage OpenLoginPage(string qaBaseURL)
        //{
        //    driver.Navigate().GoToUrl(qaBaseURL);
        //    return new VwLoginPage(driver);

        //}

        //public VwLoginPage EnterUserNameLogin(String userName)
        //{
        //    try
        //    {
        //        IWebElement userNameLogin = driver.FindElement(userNameLoc);
        //        userNameLogin.SendKeys(userName);
        //    }
        //    catch (StaleElementReferenceException e)
        //    {
        //        EnterUserNameLogin(userName);
        //    }
        //    return this;
        //}

        //public VwLoginPage EnterUserPasswordLogin(String userPassword)
        //{
        //    IWebElement userNamePassword = driver.FindElement(userPasswordLoc);
        //    userNamePassword.SendKeys(userPassword);
        //    return this;
        //}

        //public void SubmitLogin()
        //{
        //    IWebElement submitButton = driver.FindElement(submitButtonLoc);
        //    submitButton.Submit();
        //    submitButton.Click();
        //}

















        // private IWebDriver driver;

        // public VwLoginPage(IWebDriver driver) {
        //   this.driver = driver;

        // IWebElement userNameLogin = driver.FindElement(By.XPath("//input[@id='us1']"));
        //  IWebElement userNamePassword = driver.FindElement(By.XPath("//input[@id='pa1']"));
        //  IWebElement loginButton = driver.FindElement(By.XPath
        //    ("//button[@type='button'][text()='Login']"));
        //  }
        // private void OpenLoginPage()
        //  {
        //     driver.Navigate().GoToUrl("https://volkswagen.adzu4-qa-web.adzu.codeworldwide.com/#");
        // }

   // }
//