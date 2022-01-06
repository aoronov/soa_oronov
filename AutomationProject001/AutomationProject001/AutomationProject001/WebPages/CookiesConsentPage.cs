using OpenQA.Selenium;

namespace AutomationProject001
{
    class CookiesConsentPage
    {
        IWebDriver _driver;

        public CookiesConsentPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement FirstIFrame => _driver.FindElement(By.CssSelector("#abv-GDPR-frame"));
        private IWebElement SecondIFrame => _driver.FindElement(By.CssSelector("#gdpr-consent-notice"));
        private By SaveButtonLocator => By.CssSelector("#save");

        public void DismissCookiesConsentDialog()
        {
            IWebDriver frame = _driver
                .SwitchTo().Frame(FirstIFrame)
                .SwitchTo().Frame(SecondIFrame);
            frame.FindElement(SaveButtonLocator).Click();
        }

    }
}
