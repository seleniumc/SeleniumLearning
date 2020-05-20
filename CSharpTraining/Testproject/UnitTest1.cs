using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Testproject
{
    public class Tests
    {
        private object searchBoxId;
        private readonly object web;
        private object wait;
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

        [Test]
        public void TestMail()
        {
            driver = new ChromeDriver();
            lginpage = new Login(driver);
            homepage = new HomePage(driver);
            lginpage.loginpage();
            homepage.Searchmail();
        }
    }
}