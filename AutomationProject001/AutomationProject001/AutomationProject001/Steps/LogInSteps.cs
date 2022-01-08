
using AutomationProject001.Configuration;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomationProject001.Steps
{
    [Binding]
    class LogInSteps
    {

        IWebDriver _driver;
        readonly ScenarioContext _scenarioContext;

        public LogInSteps(IWebDriver driver, ScenarioContext scenarioContext)
        {
            _driver = driver;
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to Log in page")]
        public void GivenINavigateToLogInPage()
        {
            _driver.Navigate().GoToUrl(ConfigurationProvider.GetValue[ConfigurationLabels.BaseUrl]);
        }

        [When(@"I enter '(.*)' as username")]
        public void WhenIEnterAsUsername(string username)
        {
            throw new PendingStepException();
        }

        [When(@"I enter '(.*)' as password")]
        public void WhenIEnterAsPassword(string password)
        {
            throw new PendingStepException();
        }

        [When(@"I click on Submit button")]
        public void WhenIClickOnSubmitButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see Welcome user message")]
        public void ThenIShouldSeeWelcomeUserMessage()
        {
            throw new PendingStepException();
        }
    }
}
