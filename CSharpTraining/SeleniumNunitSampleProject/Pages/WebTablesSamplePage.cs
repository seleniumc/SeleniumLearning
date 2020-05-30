using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumNunitSampleProject.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumNunitSampleProject.Pages
{
    class WebTablesSamplePage
    {
        By rationCardRdoBtn = By.Id("epdsRcNoRadio2-0");
        By rationCardTxt = By.Id("epdsRcNoText1f");
        By searchBtn = By.Id("searchButtonc");
        By memberTable = By.Id("dashboarddata1c");
        By rcDetailsTableXpath = By.XPath("//*[@id='principal']/div[2]/table");
        //365410426594
        private IWebDriver searchPageDriver;
        private WebDriverWait wait;
        public WebTablesSamplePage(IWebDriver driver)
        {
            this.searchPageDriver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public void SearchRationCardAndReadWebTables()
        {
            wait.Until(ele => ele.FindElement(rationCardRdoBtn)).Click();
            wait.Until(ele => ele.FindElement(rationCardTxt)).SendKeys("365410426594");
            wait.Until(ele => ele.FindElement(searchBtn)).Click();
            Thread.Sleep(2000);
            IWebElement memTable = wait.Until(ele => ele.FindElement(memberTable));
            Utilities.DisplayTableData(memTable);
        }

        public void SearchRationCardAndValidateTCDetailsTable()
        {
            wait.Until(ele => ele.FindElement(rationCardRdoBtn)).Click();
            wait.Until(ele => ele.FindElement(rationCardTxt)).SendKeys("365410426594");
            wait.Until(ele => ele.FindElement(searchBtn)).Click();
            Thread.Sleep(5000);
            IWebElement rcDetailsTable = wait.Until(ele => ele.FindElement(rcDetailsTableXpath));
            Utilities.DisplayTableData(rcDetailsTable);
        }
    }
}
