using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeleniumNunitSampleProject.Pages
{
    class Guru99DropDownSample
    {
        private By countryDropdown = By.Name("country");
        private IWebDriver guru99Driver;
        private WebDriverWait wait;
        public Guru99DropDownSample(IWebDriver driver)
        {
            this.guru99Driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public void TestDropdownByIndex()
        {
            IWebElement countryDD = wait.Until(ele=>ele.FindElement(countryDropdown));
            SelectElement ctrySlct = new SelectElement(countryDD);
            ctrySlct.SelectByIndex(4);
        }
        public void TestDropdownByValue()
        {
            IWebElement countryDD = wait.Until(ele => ele.FindElement(countryDropdown));
            SelectElement ctrySlct = new SelectElement(countryDD);
            ctrySlct.SelectByValue("ARUBA");
        }

        public void TestDropdownByText()
        {
            IWebElement countryDD = wait.Until(ele => ele.FindElement(countryDropdown));
            SelectElement ctrySlct = new SelectElement(countryDD);
            ctrySlct.SelectByText("AZERBAIJAN");
        }
        public List<string> GetDropdownValues()
        {
            List<string> optionStrings = new List<string>();
            IWebElement countryDD = wait.Until(ele => ele.FindElement(countryDropdown));
            SelectElement ctrySlct = new SelectElement(countryDD);
            IList<IWebElement> options = ctrySlct.Options;
            foreach (IWebElement option in options)
                optionStrings.Add(option.Text);
            return optionStrings;
        }
    }
}
