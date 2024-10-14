using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestProject1
{
    public  class FirstTestCase
    {
        static void Main(string[] args)
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;
            
            
            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\123123213\\TestCase-main\\TestProject1\\TestProject1\\drivers", options);
            driver.Url = "file:///C:/Users/opilane/source/repos/PEEEEETR/ARLOOO-main/Shoppp-main/M-ng-main/index.html";
        }
    }
}
