using OpenQA.Selenium;

namespace AutomationProject001
{
    class LogInPage
    {
        IWebDriver _driver;
        //        IWebDriver driver;

        public LogInPage(IWebDriver webDriver)
        {
            _driver = webDriver;
        }

        /*
                public LogInPage(IWebDriver driver)
                {
                    this.driver = driver;
                }
        */

        private IWebElement UserNameField => _driver.FindElement(By.XPath("//input[@id='username']"));

        private IWebElement PasswordField => _driver.FindElement(By.XPath("//input[@id='password']"));

        private IWebElement SubmitButton => _driver.FindElement(By.XPath("//input[@id='loginBut']"));

        private IWebElement WrongCredentialsErrorMessage => _driver.FindElement(By.CssSelector("p#form\\.errors"));

        public void EnterUserName(string userName) 
        {
            UserNameField.Clear();
            UserNameField.SendKeys(userName);
        }
        public void EnterPassword(string password)
        {
            PasswordField.Clear();
            PasswordField.SendKeys(password);
        }
        public void ClickSubmitButton()
        {
            SubmitButton.Click();
        }
        public bool IsWrongCredentialsErrorMessageDisplayed()
        {
            return WrongCredentialsErrorMessage.Displayed;
        }
    }
}
