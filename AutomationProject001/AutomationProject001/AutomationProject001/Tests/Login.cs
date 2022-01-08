using System;
using AutomationProject001.Configuration;
using AutomationProject001.TestData;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AutomationProject001
{
    public class Tests
    {
        IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new();
            options.AddArgument("start-maximized");
            options.AddArgument("incognito");
            _driver = new ChromeDriver(options);

            // bezusloven wait (implicit), za vseki edin element - namirane + rabota s nego, generalen wait
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Double.Parse(ConfigurationProvider.GetValue[ConfigurationLabels.DefaultImplicitTimeout]));
        }

        [Test]
        public void Test1()
        {
            _driver.Navigate().GoToUrl(ConfigurationProvider.GetValue[ConfigurationLabels.BaseUrl]);
            // _driver.Manage().Window.Maximize();

            // explicit (usloven) wait, specific za stranica, element, moje da se preizpolzva ili da se iznese v base class, ima condition (napr. alert)
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            CookiesConsentPage cookiesConsentPage = new CookiesConsentPage(_driver);

            cookiesConsentPage.DismissCookiesConsentDialog();

            LogInPage logInPage = new LogInPage(_driver);

            logInPage.EnterUserName(UserTestData.DefaultIncorrectUser.UserName);
            logInPage.EnterPassword(UserTestData.DefaultIncorrectUser.Password);
            logInPage.ClickSubmitButton();

            Assert.IsTrue(logInPage.IsWrongCredentialsErrorMessageDisplayed(), "Invalid username/password was not displayed!");
        }

        [TearDown]
        public void DisposeDriver()
        {
            _driver.Dispose();
        }
    }
}