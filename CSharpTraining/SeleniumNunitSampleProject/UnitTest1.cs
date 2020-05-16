using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SampleTestProject;
using System;
using System.Collections.Generic;
using System.Threading;

namespace SeleniumNunitSampleProject
{
    public class Tests
    {
        ChromeDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestGoogle()
        {
            driver.Navigate().GoToUrl("https://wwww.google.com");
        }

        [Test]
        public void TestMS()
        {
            driver.Navigate().GoToUrl("https://wwww.microsoft.com");
        }

        [Test]
        public void TestYahoo()
        {
            driver.Navigate().GoToUrl("https://wwww.yahoo.com");
            driver.Manage().Window.Maximize();
            IWebElement searchTxtBox = driver.FindElement(By.Name("p"));
            searchTxtBox.SendKeys("Hyderabad");
            IWebElement searchBtn = driver.FindElement(By.Id("header-desktop-search-button"));
            searchBtn.Click();
        }


        [Test, TestCaseSource("GetSendMailDataFromCsv")]
        public void TestSendMail(string user, string pwd, string toem, string sub, string bdy)
        {
            driver.Navigate().GoToUrl("https://www.outlook.com");
            driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            IWebElement tmpElement = wait.Until(ele => ele.FindElement(By.LinkText("Sign in")));
            tmpElement.Click();
            tmpElement = wait.Until(ele => ele.FindElement(By.Name("loginfmt")));
            tmpElement.SendKeys(user);
            tmpElement = wait.Until(ele => ele.FindElement(By.XPath("//input[@type='submit']")));
            tmpElement.Click();
            tmpElement = wait.Until(ele => ele.FindElement(By.Name("passwd")));
            tmpElement.SendKeys(pwd);
            Thread.Sleep(3000);
            tmpElement = wait.Until(ele => ele.FindElement(By.XPath("//input[@type='submit']")));
            tmpElement.Click();
            tmpElement = wait.Until(ele => ele.FindElement(By.XPath("//span[text()='New message']")));
            tmpElement.Click();
            Thread.Sleep(3000);
            tmpElement = wait.Until(ele => ele.FindElement(By.XPath("//input[@aria-label='To']")));
            tmpElement.SendKeys(toem);
            tmpElement = wait.Until(ele => ele.FindElement(By.XPath("//input[@aria-label='Add a subject']")));
            tmpElement.SendKeys(sub);
            tmpElement = wait.Until(ele => ele.FindElement(By.XPath("//div[@aria-label='Message body']")));
            tmpElement.SendKeys(bdy);
            tmpElement = wait.Until(ele => ele.FindElement(By.XPath("//span[text()='Send']")));
            tmpElement.Click();
            tmpElement = wait.Until(ele => ele.FindElement(By.XPath("//img[@alt='RK']")));
            tmpElement.Click();
            tmpElement = wait.Until(ele => ele.FindElement(By.LinkText("Sign out")));
            tmpElement.Click();
            Thread.Sleep(2000);
            try
            {
                driver.SwitchTo().Alert().Accept();
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //driver.SwitchTo().Alert().Accept();
        }



        //Method to get data from CSV file as integers
        private static IEnumerable<string[]> GetSendMailDataFromCsv()
        {
            CsvReader reader = new CsvReader("Data/SendMail.csv");
            while (reader.Next())
            {
                string userName = reader[0];
                string password = reader[1];
                string toEmail = reader[2];
                string subject = reader[3];
                string body = reader[4];
                yield return new string[] { userName, password, toEmail, subject, body };
            }
        }

        [TearDown]
        public void Destroy()
        {
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();
        }
    }
}