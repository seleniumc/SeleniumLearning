using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SampleTestProject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace laskhmisampleselenium
{
    class SendMailTest
    {
        ChromeDriver driver;
        LoginP loginP;
        HomePage homePage;
        [setp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.outlook.com");
            driver.Manage().Window.Maximize();


        }
        [Test, TestCaseSource("GetSendMailDataFromCsv")]
        public void TestSendMail(string user, string pwd, string toem, string sub, string bdy, string txt)
        {
            loginP = new LoginP(driver);
            homePage = new HomePage(driver);
            loginP.Login(user, pwd);
            homePage.SendMail(toem, sub, bdy);
            loginP.Logout();

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
                string test = reader[5];
                yield return new string[] { userName, password, toEmail, subject, body, test };
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
