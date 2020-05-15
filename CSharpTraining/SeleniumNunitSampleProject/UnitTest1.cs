using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            IWebElement searchTxtBox= driver.FindElement(By.Name("p"));
            searchTxtBox.SendKeys("Hyderabad");
            IWebElement searchBtn = driver.FindElement(By.Id("header-desktop-search-button"));
            searchBtn.Click();
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