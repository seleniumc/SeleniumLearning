using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Testproject
{
    class HomePage
    {
        By searchtxt = By.XPath("//input[@aria-label='Search']");
        By entersearch = By.XPath("//input[@aria-label='Search']]");
        private IWebDriver loginDriver;
        private WebDriverWait wait;
        private readonly IWebElement web;
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.loginDriver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        public void Searchmail()
        {

           wait.Until(ExpectedConditions.ElementToBeClickable(searchtxt)).SendKeys("radha562@gmail.com");
            wait.Until(ExpectedConditions.ElementToBeClickable(entersearch)).Click();

        }
    }
}
