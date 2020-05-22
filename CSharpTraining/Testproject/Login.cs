using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Testproject
{
    class Login
    {
        By signinlnk = By.PartialLinkText("Sign in");
        By usernamtxt = By.Name("loginfmt");
        By usernamebtn = By.Id("idSIButton9");
        By pwdtxt = By.Name("passwd");
        By pwdbtn = By.Id("idSIButton9");
        private IWebDriver loginDriver;
        private WebDriverWait wait;
        private readonly IWebElement web;
        public Login(IWebDriver driver)
        {
            this.loginDriver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void Login(string user, string pwd)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(signinlnk)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(usernamtxt)).SendKeys("radha563@outlook.com");
            wait.Until(ExpectedConditions.ElementToBeClickable(usernamebtn)).Click();
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementToBeClickable(pwdtxt)).SendKeys("amma@1234");
            wait.Until(ExpectedConditions.ElementToBeClickable(pwdbtn)).Click();
        }
    }
}

