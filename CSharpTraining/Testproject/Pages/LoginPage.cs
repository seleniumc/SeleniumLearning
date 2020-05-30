using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Testproject.Pages
{
    class LoginPage
    {
        By singinLnk = By.LinkText("Sign in");
        By userNameTxt = By.Name("loginfmt");
        By submitBtn = By.XPath("//input[@type='submit']");
        By passwordTxt = By.Name("passwd");
        private IWebDriver logdriver;
        private WebDriverWait wait;



        public LoginPage(IWebDriver driver)
        {
            this.logdriver = driver;
            this.wait = new WebDriverWait(driver,TimeSpan.FromSeconds(15));
        }
      public void Login(string username,string password)
        {
            wait.Until(ele => ele.FindElement(singinLnk));
            wait.Until(ele => ele.FindElement(userNameTxt));
            wait.Until(ele => ele.FindElement(submitBtn));
            wait.Until(ele => ele.FindElement(passwordTxt));
            Thread.Sleep(3000);
            wait.Until(ele => ele.FindElement(submitBtn));


        }
    }
}
