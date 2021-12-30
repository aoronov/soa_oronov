using System;
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
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            _driver = new ChromeDriver(options);

            // bezusloven wait (implicit), za vseki edin element - namirane + rabota s nego, generalen wait
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void Test1()
        {
            _driver.Navigate().GoToUrl("http://localhost:8081/login.php");
            // _driver.Manage().Window.Maximize();

            // explicit (usloven) wait, specific za stranica, element, moje da se preizpolzva ili da se iznese v base class, ima condition (napr. alert)
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            LogInPage logInPage = new LogInPage(_driver);

            logInPage.EnterUserName("admin@automation.com");
            logInPage.EnterPassword("pass123");
            logInPage.ClickSubmitButton();

            // Assert.IsFalse(_driver.FindElement(By.XPath("//p[@id='form.error']")).Displayed, "Invalid username/password!");
        }

        [TearDown]
        public void DisposeDriver()
        {
            _driver.Dispose();
        }
    }
}