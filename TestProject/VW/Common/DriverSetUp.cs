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
                String driverPath = "D:\\Microsoft Visual Studio\\2017\\Projects\\TestProject\\TestProject";
                driver = new ChromeDriver(@driverPath);
            }
        }
        public IWebDriver GetDriver()
        {
            return driver;
        }
    }
}
