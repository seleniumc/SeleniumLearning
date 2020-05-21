using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Testproject.PageObject
{
    class HomPage
    {
        By newMessageBtn = By.XPath("//span[text()='New message']");
        By toTxt = By.XPath("//input[@aria-label='To']");
        By subjectTxt = By.XPath("//input[@aria-label='Add a subject']");
        By bodyTxt = By.XPath("//div[@aria-label='Message body']");
        By sendBtn = By.XPath("//span[text()='Send']");
        By selectallmsgs = By.XPath("//div[@aria-label='Select all messages']");
        By markalread = By.Id("id__774");
        By delet = By.ClassName("ms - Button - label label - 70");
        private IWebDriver loginDriver;
        private WebDriverWait wait;
        public HomPage(IWebDriver driver)
        {
            this.loginDriver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(300));
        }
        public void SendMail(string toEmail,string subject,string body)
        {
            wait.Until(ele => ele.FindElement(newMessageBtn)).Click();
            Thread.Sleep(3000);
            wait.Until(ele => ele.FindElement(toTxt)).SendKeys(toEmail);
            wait.Until(ele => ele.FindElement(subjectTxt)).SendKeys(subject);
            wait.Until(ele => ele.FindElement(bodyTxt)).SendKeys(body);
            wait.Until(ele => ele.FindElement(sendBtn)).Click();
            wait.GetHashCode(ElementClickInterceptedException(selectallmsgs));
            wait.Until(ele => ele.FindElement(markalread)).Click();
            wait.Until(ele => ele.FindElement(delet)).Click();
        }
    }
}
