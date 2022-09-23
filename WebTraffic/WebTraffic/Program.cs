using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.IO;

namespace WebTraffic
{
    internal class Program
    {
        static string root = "https://www.dataras.cz/testovacka/";
        static string gtm = "?gtm=GTM-P6V8LX5";

        static IWebDriver driver;

        static Random rnd = new Random();
        static int num = 4;

        static void Main(string[] args)
        {
            while (true)
            {
                driver = new FirefoxDriver();
                for (int i = 0; i < num; i++)
                {
                    Run1();
                }
                for (int i = 0; i < num; i++)
                {
                    Run2();
                }
                driver.Close();
                driver = new EdgeDriver();
                for (int i = 0; i < num; i++)
                {
                    Run1();
                }
                for (int i = 0; i < num; i++)
                {
                    Run2();
                }
                driver.Close();
                driver = new ChromeDriver();
                for (int i = 0; i < num; i++)
                {
                    Run1();
                }
                for (int i = 0; i < num; i++)
                {
                    Run2();
                }
                driver.Close();
            }
        }

        static void Run1()
        {
            driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "t");

            driver.Navigate().GoToUrl(root + gtm);

            List<IWebElement> whereToGo = new List<IWebElement>();

            foreach (IWebElement item in driver.FindElements(By.XPath("/html/body/nav/div/ul/li/a")))
            {
                string href = item.GetAttribute("href");
                if (href.Contains("testovacka") && !href.Contains(root + gtm))
                {
                    whereToGo.Add(item);
                }
            }

            driver.FindElement(By.XPath("/html/body/div[1]/header/nav/a")).Click();
            Thread.Sleep(1500);
            whereToGo[rnd.Next(0,whereToGo.Count)].Click();
            Thread.Sleep(1000);

            driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "w");
        }

        static void Run2()
        {
            driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "t");

            driver.Navigate().GoToUrl(root + gtm);

            List<string> whereToGo = new List<string>();

            foreach (IWebElement item in driver.FindElements(By.TagName("a")))
            {
                string href = item.GetAttribute("href");
                if (href.Contains("testovacka") && !href.Contains(root + gtm))
                {
                    whereToGo.Add(href);
                }
            }
            foreach (var item in whereToGo)
            {
                driver.Navigate().GoToUrl(item + gtm);

                Thread.Sleep(1500);
            }
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "w");
        }
    }
}
