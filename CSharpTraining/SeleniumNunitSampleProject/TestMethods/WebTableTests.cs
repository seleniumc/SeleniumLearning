using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumNunitSampleProject.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumNunitSampleProject.TestMethods
{
    class WebTableTests
    {
        ChromeDriver driver;
        WebTablesSamplePage wtsPage;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://epds.telangana.gov.in/FoodSecurityAct/?wicket:bookmarkablePage=:nic.fsc.foodsecurity.FscSearch");
            driver.Manage().Window.Maximize();
            wtsPage = new WebTablesSamplePage(driver);
        }
        [Test]
        public void TestWebtable()
        {
            wtsPage.SearchRationCardAndReadWebTables();
        }

        [Test]
        public void TestRCDetailsTable()
        {
            wtsPage.SearchRationCardAndValidateTCDetailsTable();
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
