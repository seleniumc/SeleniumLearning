using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumNunitSampleProject.Pages
{
    class LoginPage
    {
        By singinLnk = By.LinkText("Sign in");
        By userNameTxt = By.Name("loginfmt");
        By submitBtn = By.XPath("//input[@type='submit']");
        By passwordTxt = By.Name("passwd");
        By signoutImage = By.XPath("//img[@alt='RK']");
        By signoutLink = By.LinkText("Sign out");
        private IWebDriver loginDriver;
        private WebDriverWait wait;
        public LoginPage(IWebDriver driver)
        {
            this.loginDriver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public void Login(string userName, string passWord)
        {
            wait.Until(ele => ele.FindElement(singinLnk)).Click();
            wait.Until(ele => ele.FindElement(userNameTxt)).SendKeys(userName);
            wait.Until(ele => ele.FindElement(submitBtn)).Click();
            wait.Until(ele => ele.FindElement(passwordTxt)).SendKeys(passWord);
            Thread.Sleep(3000);
            wait.Until(ele => ele.FindElement(submitBtn)).Click();
        }
        public void Logout()
        {
            Thread.Sleep(2000);
            wait.Until(ele => ele.FindElement(signoutImage)).Click();
            wait.Until(ele => ele.FindElement(signoutLink)).Click();
            Thread.Sleep(2000);
            try
            {
                loginDriver.SwitchTo().Alert().Accept();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
