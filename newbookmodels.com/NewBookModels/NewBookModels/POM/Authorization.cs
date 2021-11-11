using OpenQA.Selenium;


namespace NewBookModels.POM
{
    class Authorization
    {
        private readonly IWebDriver _driver;

        private readonly By _buttonLogInFooter = By.CssSelector("[class=\"Navbar__navLink--3lL7S Navbar__navLinkSingle--3x6Lx Navbar__login--28b35 \"]");
        private readonly By _fieldEmailAdress = By.CssSelector("[class=\"Input__input--_88SI Input__themeNewbook--1IRjd Input__fontRegular--2SStp\"]");
        private readonly By _fieldPassword = By.CssSelector("[name=password]");
        private readonly By _buttonLogIn = By.CssSelector("[type=submit]");
               
        public Authorization(IWebDriver webDriver)
        {
            _driver = webDriver;
        }
        public Authorization GoToLogIn()
        {

            _driver.FindElement(_buttonLogInFooter).Click();
            return this;
        }


        public Authorization InputEmailAdress(string emailAdress)
        {
            _driver.FindElement(_fieldEmailAdress).SendKeys(emailAdress);
            return this;
        }
        public Authorization InputPassword(string passwrd)
        {
            _driver.FindElement(_fieldPassword).SendKeys(passwrd);
            return this;
        }
              
        public void ClickOnFinishRegistration() => _driver.FindElement(_buttonLogIn).Click();
    }
}
