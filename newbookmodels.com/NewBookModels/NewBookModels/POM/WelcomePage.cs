using OpenQA.Selenium;


namespace NewBookModels.POM
{
    class WelcomePage
    {
        private readonly IWebDriver _driver;

        private readonly By _welcomeInAcc = By.CssSelector("[class='WelcomePage__welcomeBackSection--1fVmu'] [class='Section__title--1wSQt']");

        public WelcomePage(IWebDriver webDriver)
        {
            _driver = webDriver;
        }

        public string CheckTryLogIn =>
            _driver.FindElement(_welcomeInAcc).Text;

    }
}
