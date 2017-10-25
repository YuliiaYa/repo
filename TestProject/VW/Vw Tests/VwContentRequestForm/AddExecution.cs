using NUnit.Framework;
using TestProject.Vw_Tests;
using TestProject.VW.Vw_Pages;
using TestProject.VW.TestData;

namespace TestProject.VW.Vw_Tests
{
    [TestFixture]
    class AddExecution : InitTest
    {
        public AddExecution(): base() {
            this.siteURL = "https://volkswagen.adzu4-qa-web.adzu.codeworldwide.com/#RequestForm/Executions/6f5ab54c-446d-eb48-87e4-39e140d42aed";
        }
        [Test]
        public void AddExecutionAsCentralMarketUser()
        {
            VwLoginPage loginPage = new VwLoginPage(driver);
            VwContentRequestForm crf = new VwContentRequestForm(driver);

            loginPage.Login(VwLoginDataQa.centralMarketCorrectLogin, VwLoginDataQa.centralMarketCorrectPassword);
            WaitTillPageLoad(15.00);

            //crf.IsButtonDisplayed(crf.addExecutionButtonLoc);
            crf.ClickAddExecution();
       


        }
}









}
