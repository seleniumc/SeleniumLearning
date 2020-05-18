using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SampleTestProject;
using SeleniumNunitSampleProject.Pages;
using System.Collections.Generic;
using System.Threading;

namespace SeleniumNunitSampleProject.TestMethods
{
    class SendMailTests
    {
        ChromeDriver driver;
        LoginPage loginPage;
        HomePage homePage;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.outlook.com");
            driver.Manage().Window.Maximize();
        }

        [Test, TestCaseSource("GetSendMailDataFromCsv")]
        public void TestSendMail(string user, string pwd, string toem, string sub, string bdy)
        {
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            loginPage.Login(user, pwd);
            homePage.SendMail(toem, sub, bdy);
            loginPage.Logout();
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
            Thread.Sleep(10000);
            driver.Close();
            driver.Quit();
        }
    }
}
