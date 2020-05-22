using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace laskhmisampleselenium
{
     class HomePage
    {
        By newMessageBtn = By.XPath("//span[text()=new message']");
        By toTxt = By.XPath("//input[@aria-lable='To']");
        By subjectTxt = By.XPath("//input[@aria-lable='Add a subject']");
        By bodyTxt = By.XPath("//input[@aria-lable='Message body']");
        By sendBtn = By.XPath("//span[text()'send']");

        private IWebDriver loginDriver;
        private WebDriverWait wait;
        public HomePage(IWebDriver driver)
        {
            this.loginDriver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

        }
        public void SendMail(string toEmail, string subject, string body)
        {
            wait.Until(ele => ele.FindElement(newMessageBtn)).Click();
            Thread.Sleep(2000);
            wait.Until(ele => ele.FindElement(toTxt)).SendKeys(toEmail);
            wait.Until(ele=>ele.FindElement(subjectTxt)).SendKeys(subject);
            wait.Until(ele => ele.FindElement(bodyTxt)).SendKeys(body);
            wait.Until(ele => ele.FindElement(sendBtn)).Click();
        }
    }
}