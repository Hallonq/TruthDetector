using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;

namespace TruthDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SeleniumService seleniumService = new SeleniumService();
            //IWebDriver driver = seleniumService.CreateSeleniumWithInputSearch(args[0]); CONSOLE (DYNAMIC URL)
            IWebDriver driver = seleniumService.CreateSeleniumWithInputSearch("https://duckduckgo.com/?q=is+queen+elizabeth%27s+alive&ia=web"); // STATIC URL

            LogicService logicService = new LogicService();
            List<string> ids = logicService.GetResultIds();

            logicService.GetUrlsOfIds(driver, ids);
        }
    }
}