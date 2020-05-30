using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testproject.Pages
{
    class FscSearch
    {
       private By districtdropdown = By.Id("alldistrictsb");
        private IWebDriver driver;
        private WebDriverWait wait;
       public FscSearch(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(25));
        }
        public void TestdropdownByIndex()
        {
            IWebElement DistDD = wait.Until(ele=>ele.FindElement(districtdropdown));
            SelectElement dissel = new SelectElement(DistDD);
            dissel.SelectByIndex(9);
        }
        public void TestdropdownByValue()
        {
            IWebElement DistDD = wait.Until(ele => ele.FindElement(districtdropdown));
            SelectElement dissel = new SelectElement(DistDD);
            dissel.SelectByValue("9");
                    }
        public void testDropdownbyText()
        {
            IWebElement DistDD = wait.Until(ele => ele.FindElement(districtdropdown));
            SelectElement dissel = new SelectElement(DistDD);
            dissel.SelectByText("Hyderabad");
        }
        public List<string> GetDropdownValues()
        {
            List<string> optionStrings = new List<string>();
            IWebElement DistDD = wait.Until(ele => ele.FindElement(districtdropdown));
            SelectElement dissel = new SelectElement(DistDD);
            IList<IWebElement> options = dissel.Options;
            foreach (IWebElement option in options)
                optionStrings.Add(option.Text);
            return optionStrings;
        }
    }
}
