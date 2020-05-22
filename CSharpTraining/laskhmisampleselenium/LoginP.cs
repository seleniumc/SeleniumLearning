using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace laskhmisampleselenium
{
    class LoginP
    {//*[@id="yDmH0d"]/div[1]/div[2]
        //*[@id="headingText"]
        By singinLink = By.LinkText("sing in");
        By userNameTxt = By.Name("loginfmt");
        By submitBtn = By.XPath("//input[@type='submit']");
        By passwordTxt = By.Name("password");
        By singoutImage = By.LinkText("//img[@alt='LAkshmi']");
        By signoutLink = By.LinkText("Sign out");
        private IWebDriver loginDriver;
        private WebDriverWait wait;
        private object loginDrive;

        public LoginP(IWebDriver driver)
        {
            this.loginDriver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

        }
        public void Login(string userName, string passWord)
        {
            wait.Until(ele => ele.FindElement(singinLink)).Click();
            wait.Until(ele => ele.FindElement(userNameTxt)).SendKeys(userName);
            wait.Until(ele => ele.FindElement(submitBtn)).Click();
            wait.Until(ele => ele.FindElement(passwordTxt)).SendKeys(passWord);
            Thread.Sleep(3000);
            wait.Until(ele => ele.FindElement(submitBtn)).Click();
        }
        public void Logout()
        {
            Thread.Sleep(2000);
            wait.Until(ele => ele.FindElement(singoutImage)).Click();
            wait.Until(ele => ele.FindElement(signoutLink)).Click();
            Thread.Sleep(2000);
            try
            {
                loginDriver.SwitchTo().Alert().Accept();
            }
            catch(Exception e)
            {
                Console.WriteLine("e.message");

            }

        }
    }
}
