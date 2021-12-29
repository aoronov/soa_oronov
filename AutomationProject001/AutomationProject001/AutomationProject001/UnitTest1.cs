using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject001
{
    public class Tests
    {
        IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            _driver.Navigate().GoToUrl("http://localhost:8081/login.php");
            _driver.Manage().Window.Maximize();

            _driver.FindElement(By.XPath("//input[@name='email']")).Clear();
            _driver.FindElement(By.XPath("//input[@name='email']")).SendKeys("admin@automation.com");

            _driver.FindElement(By.XPath("//input[@name='pass']")).Clear();
            _driver.FindElement(By.XPath("//input[@name='pass']")).SendKeys("pass123");

            _driver.FindElement(By.XPath("//button[@name='btn-login']")).Click();

        }

        [TearDown]
        public void DisposeDriver()
        {
            _driver.Dispose();
        }
    }
}