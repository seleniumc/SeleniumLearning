using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumNunitSampleProject.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace SeleniumNunitSampleProject.TestMethods
{
    class DropDownTests
    {
        IWebDriver driver;
        Guru99DropDownSample guru99Page;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://demo.guru99.com/test/newtours/register.php");
            guru99Page = new Guru99DropDownSample(driver);
        }

        [Test]
        public void TestDropdownWithIndex()
        {
            guru99Page.TestDropdownByIndex();
        }
        [Test]
        public void TestDropdownWithValue()
        {
            guru99Page.TestDropdownByValue();
        }

        [Test]
        public void TestDropdownWithText()
        {
            guru99Page.TestDropdownByText();
        }
        [Test]
        public void TestDropdownValues()
        {
            List<string> options = guru99Page.GetDropdownValues();
            /*foreach (string s in options)
                //Console.WriteLine(s);*/
            string[] valuesFromFile = File.ReadAllLines("data/CountryDropDownValues.txt");
            string[] valuesFromPage = options.ToArray();
            bool areEqual= Enumerable.SequenceEqual(valuesFromFile, valuesFromPage);
            Console.WriteLine(areEqual);
            Assert.IsTrue(areEqual);
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
