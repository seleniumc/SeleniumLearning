using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumNunitSampleProject.Pages
{
    class HomePage
    {
        By newMessageBtn = By.XPath("//span[text()='New message']");
        By toTxt = By.XPath("//input[@aria-label='To']");
        By subjectTxt = By.XPath("//input[@aria-label='Add a subject']");
        By bodyTxt = By.XPath("//div[@aria-label='Message body']");
        By sendBtn=By.XPath("//span[text()='Send']");
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
            Thread.Sleep(3000);
            wait.Until(ele => ele.FindElement(toTxt)).SendKeys(toEmail);
            wait.Until(ele => ele.FindElement(subjectTxt)).SendKeys(subject);
            wait.Until(ele => ele.FindElement(bodyTxt)).SendKeys(body);
            wait.Until(ele => ele.FindElement(sendBtn)).Click();
        }
    }
}
