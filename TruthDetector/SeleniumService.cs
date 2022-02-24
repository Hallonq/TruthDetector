using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace TruthDetector
{
    internal class SeleniumService
    {
        public SeleniumService()
        {
        }

        internal IWebDriver CreateSeleniumWithInputSearch(string searchInput)
        {
            IWebDriver driver = new EdgeDriver("C:\\Users\\ludwig.johansson\\Downloads\\edgedriver_win64");
            driver.Url = searchInput;

            
            return driver;
        }
    }
}