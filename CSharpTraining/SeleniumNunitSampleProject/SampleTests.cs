using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SampleTestProject;
using SeleniumNunitSampleProject.Pages;
using System;
using System.Collections.Generic;
using System.Threading;

namespace SeleniumNunitSampleProject
{
    public class SampleTests
    {
        ChromeDriver driver;
        LoginPage loginPage;
        HomePage homePage;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
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

        [TearDown]
        public void Destroy()
        {
            Thread.Sleep(10000);
            driver.Close();
            driver.Quit();
        }
    }
}