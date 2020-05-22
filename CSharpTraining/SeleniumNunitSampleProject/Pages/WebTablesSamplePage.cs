using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
            wait.Until(ele=>ele.FindElement(rationCardRdoBtn)).Click();
            wait.Until(ele => ele.FindElement(rationCardTxt)).SendKeys("365410426594");
            wait.Until(ele => ele.FindElement(searchBtn)).Click();
            Thread.Sleep(2000);
            IWebElement memTable = wait.Until(ele => ele.FindElement(memberTable));
            IList<IWebElement> trs = memTable.FindElements(By.TagName("tr"));          
            foreach(IWebElement tr in trs)
            {
                IList<IWebElement> tds = tr.FindElements(By.TagName("td"));
                if (tds.Count > 0)
                {
                    foreach (IWebElement td in tds)
                        Console.Write(td.Text + "\t");
                    Console.WriteLine();
                }
                else
                {
                    IList<IWebElement> ths = tr.FindElements(By.TagName("th"));
                    foreach (IWebElement th in ths)
                        Console.Write(th.Text + "\t");
                    Console.WriteLine();
                }                
            }
        }
    }
}
