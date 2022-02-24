using OpenQA.Selenium;

namespace TruthDetector
{
    internal class LogicService
    {
        public LogicService()
        {
        }

        internal List<string> GetResultIds()
        {
            List<string> resultIdsList = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                resultIdsList.Add($"r1-{ i }");
            }
            return resultIdsList;
        }
            // trash
        internal List<string> GetUrlsOfIds(IWebDriver driver, List<string> ids)
        {
            List<string> urls = new List<string>();
            foreach (string id in ids)
            {
                urls.Add(driver.FindElement(By.XPath(".//*")).ToString());
            }

            return urls;
        }
    }
}