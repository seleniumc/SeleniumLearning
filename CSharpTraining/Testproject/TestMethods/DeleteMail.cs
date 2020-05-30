using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using SampleTestProject;
using System;
using System.Collections.Generic;
using System.Text;
using Testproject.Pages;

namespace Testproject.TestMethods
{
    class DeleteMail
    {
        ChromeDriver driver;
        LoginPage loginpage;
     

        [SetUp]
       public void Setup()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.outlook.com");
            driver.Manage().Window.Maximize();
            driver.Close();
            driver.Quit();
        }
        [Test,TestCaseSource("GetDeleteMailDataFromCsv")]
        public void Deletmail(string user,string pwd)
        {
            loginpage = new LoginPage(driver);
            loginpage.Login(user, pwd);
                
        }
        private static IEnumerable<string[]> GetDeleteMailDataFromCsv()
        {
            CsvReader reader = new CsvReader("Data/Delet.csv");
            while (reader.Next())
            {
                string userName = reader[0];
                string password = reader[1];
                yield return new string[] { userName, password};
            }
        }
    }
}
