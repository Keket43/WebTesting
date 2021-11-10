using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBookModels.POM
{   
    class SignInPage
    {
        private readonly IWebDriver _driver;

        private readonly By _emailField = By.CssSelector("input[type=email]");
        private readonly By _passwordField = By.CssSelector("input[type=password]");
        private readonly By _loginButton = By.CssSelector("button[class^=SignInForm__submitButton]");
        private readonly By _errorMessage = By.XPath("//*[contains(@class, 'SignInForm__submitButton')]/../../div[contains(@class, 'PageFormLayout__errors--3dFcq')]/div/div");
                
        public SignInPage(IWebDriver webDriver)
        {
            _driver = webDriver;
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
        //можно так записывать, красивее:
        public void ClickLoginButton() =>
            _driver.FindElement(_loginButton).Click();

        public string GetErrorMessage() =>
            _driver.FindElement(_errorMessage).Text;
    }
}
