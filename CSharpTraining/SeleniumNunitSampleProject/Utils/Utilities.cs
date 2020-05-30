using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumNunitSampleProject.Utils
{
    class Utilities
    {
        public static void DisplayTableData(IWebElement table)
        {
            IList<IWebElement> trs = table.FindElements(By.TagName("tr"));
            foreach (IWebElement tr in trs)
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
