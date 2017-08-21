using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject.VW.Unit
{
    public class DriverSetUp
    {
        private IWebDriver driver;

        public DriverSetUp(String browser)
        {
            if (browser.Equals("ChromeWindows"))
            {
                String driverPath = "D:\\Microsoft Visual Studio\\2017\\Projects\\TestProject\\packages\\WebDriverChromeDriver.2.10\\tools\\";
                driver = new ChromeDriver(@driverPath);
            }
            // other drivers initialization
        }
        public IWebDriver GetDriver()
        {
            return driver;
        }
    }
}
