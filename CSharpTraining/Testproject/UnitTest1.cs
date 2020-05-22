using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SampleTestProject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Testproject
{
    public class Tests
    {
        private Login lginpage;
        private HomePage homepage;
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://WWW.outlook.com");
            driver.Manage().Window.Maximize();
        }

        [Test,TestCaseSource("GetSendMailDataFromCsv")]
        public void TestSendMail(String user,string pwd,string,string toem,string sub,string bdy,string txt)
        {
            driver = new ChromeDriver();
            lginpage = new Login(driver);
            homepage = new HomePage(driver);
            lginpage.Login(user,pwd);
            homepage.SendMail(toem,sub,bdy,txt);
        }
        private static IEnumerable<string[]> GetSendMailDataFromCsv()
        {
            CsvReader reader = new CsvReader("Data/SendMail.Csv");
            while(reader.Next())
            {
                string username = reader[0];
                string password = reader[1];
                string toEmail = reader[2];
                string subject = reader[3];
                string body = reader[4];
                string test = reader[5];
                yield return new string[] { username, password, toEmail, subject, body, test };
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