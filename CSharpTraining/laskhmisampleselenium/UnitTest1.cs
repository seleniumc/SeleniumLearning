using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace laskhmisampleselenium
{
    public class Tests
    {
        ChromeDriver driver;
        LoginP loginP;
        HomePage homePage;




        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void TestBing()
        {
            driver.Navigate().GoToUrl("https://www.bing.com/");
            driver.Manage().Window.Maximize();
            IWebElement searchTxtBox = driver.FindElement(By.Name("q"));
            searchTxtBox.SendKeys("Brisbane");
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