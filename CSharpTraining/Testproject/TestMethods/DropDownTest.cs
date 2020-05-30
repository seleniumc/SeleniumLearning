using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Testproject.Pages;

namespace Testproject.TestMethods
{
    class DropDownTest
    {
        IWebDriver driver;
        FscSearch dists;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://epds.telangana.gov.in/FoodSecurityAct/?wicket:bookmarkablePage=:nic.fsc.foodsecurity.FscSearch");
            driver.Manage().Window.Maximize();
            dists = new FscSearch(driver);
        }
        [Test]
        public void TestDropDownWithIndex()
        {
            dists.TestdropdownByIndex();
        }
        [Test]
        public void TestDropDownByvalue()
        {
            dists.TestdropdownByValue();
        }
        [Test]
        public void TestDropDownByText()
        {
            dists.testDropdownbyText();

        }
        [Test]
        public void Testdropdownvalues()
        {
            List<string> options = dists.GetDropdownValues();
           // foreach (string s in options)
             //   Console.WriteLine(s);
            string[] valuesFromfile = File.ReadAllLines("Data/DistDropDown.txt");
            string[] valuesfrompage = options.ToArray();
            bool areEqual = Enumerable.SequenceEqual(valuesFromfile, valuesfrompage);
            Console.WriteLine(areEqual);
            Assert.IsTrue(areEqual);
        }
    }
}
