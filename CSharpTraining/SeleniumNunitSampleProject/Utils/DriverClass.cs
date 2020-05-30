using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumNunitSampleProject.Utils
{
    class DriverClass
    {
        public IWebDriver CreateDriver(string type)
        {
            if (type.Equals("Chrome"))
                return new ChromeDriver();
            if (type.Equals("IE"))
            {
                var options = new InternetExplorerOptions { EnableNativeEvents = false };
                options.AddAdditionalCapability("disable-popup-blocking", true);
                options.PageLoadStrategy = PageLoadStrategy.Eager;
                IWebDriver driver = new InternetExplorerDriver(options);
                return driver;
            }
            if (type.Equals("Firefox"))
                return new FirefoxDriver();

            return new ChromeDriver();
        }
    }
}
