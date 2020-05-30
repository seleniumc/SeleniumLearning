using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SampleTestProject;
using SeleniumNunitSampleProject.Pages;
using SeleniumNunitSampleProject.Utils;
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
       
        public void Setup(string browser)
        {
            driver = new DriverClass().CreateDriver(browser);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://demo.guru99.com/test/newtours/register.php");
            guru99Page = new Guru99DropDownSample(driver);
        }

        [Test,TestCaseSource("GetSendMailDataFromCsv")]
        public void TestDropdownWithIndex(string browser)
        {
            Setup(browser);
            guru99Page.TestDropdownByIndex();
        }

        [Test, TestCaseSource("GetSendMailDataFromCsv")]
        public void TestDropdownWithValue(string browser)
        {
            Setup(browser);
            guru99Page.TestDropdownByValue();
        }

        [Test, TestCaseSource("GetSendMailDataFromCsv")]
        public void TestDropdownWithText(string browser)
        {
            Setup(browser);
            guru99Page.TestDropdownByText();
        }
        
        [Test, TestCaseSource("GetSendMailDataFromCsv")]
        public void TestDropdownValues(string browser)
        {
            Setup(browser);
            List<string> options = guru99Page.GetDropdownValues();
            /*foreach (string s in options)
                //Console.WriteLine(s);*/
            string[] valuesFromFile = File.ReadAllLines("data/CountryDropDownValues.txt");
            string[] valuesFromPage = options.ToArray();
            bool areEqual= Enumerable.SequenceEqual(valuesFromFile,valuesFromPage);
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

        //Method to get data from CSV file as integers
        private static IEnumerable<string[]> GetSendMailDataFromCsv()
        {
            CsvReader reader = new CsvReader("Data/dropdowntests.csv");
            while (reader.Next())
            {
                string browser = reader[0];
                
                yield return new string[] { browser };
            }
        }
    }
}
