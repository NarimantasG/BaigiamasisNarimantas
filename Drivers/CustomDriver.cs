using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Drivers
{
    public class CustomDriver
    {

        public static IWebDriver GetChromeDriver()
        {

            return GetDriver(Browsers.Chrome);
        }
        public static IWebDriver GetIncognitoChromeDriver()
        {

            return GetDriver(Browsers.IncognitoChrome);
        }
        public static IWebDriver GetFirefoxDriver()
        {

            return GetDriver(Browsers.Firefox);
        }

        private static IWebDriver GetDriver(Browsers browsersName)
        {
            IWebDriver webDriver = null;

            switch (browsersName)
            {
                case Browsers.Chrome:
                    webDriver = new ChromeDriver();
                    break;

                case Browsers.IncognitoChrome:
                    webDriver = GetChromeWithIncognitoOption();
                    break;

                case Browsers.Firefox:
                    webDriver = new FirefoxDriver();
                    break;

                default:
                    webDriver = new ChromeDriver();
                    break;
            }
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            return webDriver;
        }
        private static IWebDriver GetChromeWithIncognitoOption()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("incognito");
            options.AddArguments("incognito", "stari-maximized");

            return new ChromeDriver(options);
        }

    }
}
