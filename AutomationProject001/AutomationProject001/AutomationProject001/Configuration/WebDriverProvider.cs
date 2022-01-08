
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject001.Configuration
{
    class WebDriverProvider
    {

        static IWebDriver _driver;
        public static void SetupChromeDriver()
        {
            ChromeOptions options = new();
            options.AddArgument("start-maximized");
            options.AddArgument("incognito");
            _driver = new ChromeDriver(options);

            // bezusloven wait (implicit), za vseki edin element - namirane + rabota s nego, generalen wait
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Double.Parse(ConfigurationProvider.GetValue[ConfigurationLabels.DefaultImplicitTimeout]));
        }

        public static IWebDriver GetCurrentDriver()
        {
            return _driver;
        }
    }
}
