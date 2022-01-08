
using AutomationProject001.Configuration;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomationProject001.Hooks
{
    [Binding]
    // bind-va tozi class kam nqkakav execution
    public class Webhook
    {
        public IWebDriver _driver;
        [BeforeScenario]
        public void SetUp() 
        {
            WebDriverProvider.SetupChromeDriver();
        }

        [AfterScenario]
        public void TearDown()
        {
            _driver = WebDriverProvider.GetCurrentDriver();
            _driver.Dispose();
        }
    }
}
