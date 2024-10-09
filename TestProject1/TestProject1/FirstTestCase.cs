using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestProject1
{
    public  class FirstTestCase
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://store.steampowerd.com/";
        }
    }
}
