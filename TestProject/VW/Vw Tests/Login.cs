using System;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject.Vw_Tests;
using TestProject.VW.Vw_Pages;

namespace TestProject.VW.Vw_Tests
{
    [TestFixture]
    public class Login : InitTest
    {
       
        [Test]
        public void LoginToHomePage()
        {
            VwLoginPage loginPage = new VwLoginPage(driver);
            loginPage.OpenLoginPage();           

        }
    }
}
