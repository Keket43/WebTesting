using OpenQA.Selenium;


namespace NewBookModels.POM
{   
    class SignInPage
    {
        private readonly IWebDriver _driver;

        private readonly By _emailField = By.CssSelector("input[type=email]");
        private readonly By _passwordField = By.CssSelector("input[type=password]");
        private readonly By _loginButton = By.CssSelector("button[class^=SignInForm__submitButton]");
        private readonly By _errorMessage = By.XPath("//*[contains(@class, 'SignInForm__submitButton')]/../../div[contains(@class, 'PageFormLayout__errors--3dFcq')]/div/div");
        private readonly By _verifSignInPage = By.CssSelector("div[class='PageCard__title--3_OBR']");

        public SignInPage(IWebDriver webDriver)
        {
            _driver = webDriver;
        }
        public string SignInPageVerif()
        {
            return _driver.FindElement(_verifSignInPage).Text;
        }

        public SignInPage GoToSignInPage()
        {
            _driver.Navigate().GoToUrl("https://newbookmodels.com/auth/signin");
            return this;
        }
        
        public SignInPage InputEmailField(string email)
        {
            _driver.FindElement(_emailField).SendKeys(email);
            return this;
        }

        public SignInPage InputPasswordField(string password)
        {
            _driver.FindElement(_passwordField).SendKeys(password);
            return this;
        }        
        public void ClickLoginButton() =>
            _driver.FindElement(_loginButton).Click();

        public string GetErrorMessage() =>
            _driver.FindElement(_errorMessage).Text;
    }
}
