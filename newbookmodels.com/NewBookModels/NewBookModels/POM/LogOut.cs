using OpenQA.Selenium;


namespace NewBookModels.POM
{
    class LogOut
    {
        private readonly IWebDriver _driver;

        private readonly By _buttonLogInFooter = By.CssSelector("[class=\"Navbar__navLink--3lL7S Navbar__navLinkSingle--3x6Lx Navbar__login--28b35 \"]");
        private readonly By _fieldEmailAdress = By.CssSelector("[class=\"Input__input--_88SI Input__themeNewbook--1IRjd Input__fontRegular--2SStp\"]");
        private readonly By _fieldPassword = By.CssSelector("[name=password]");

        private readonly By _buttonLogIn = By.CssSelector("[type=submit]");
        private readonly By _buttonMyAvaFooter = By.CssSelector("[class=\"AvatarClient__avatar--3TC7_\"]");
        private readonly By _buttonLodOutAcc = By.CssSelector("[class=\"link link_type_logout link_active\"]");

       
        public LogOut(IWebDriver webDriver)
        {
            _driver = webDriver;
        }
       
        public LogOut ClickButtonFooterLogIn()
        {
            _driver.FindElement(_buttonLogInFooter).Click();
        }
        public LogOut InputEmailAdress(string emailAdress)
        {
            _driver.FindElement(_fieldEmailAdress).SendKeys(emailAdress);
            return this;
        }
        public LogOut InputPassword(string passwrd)
        {
            _driver.FindElement(_fieldPassword).SendKeys(passwrd);
            return this;
        }

        public void ClickButtonLogIn() => _driver.FindElement(_buttonLogIn).Click();
        //public void ClickLogInButton()
        //{
        //    _driver.FindElement(_buttonLogIn).Click();
        //}
        public LogOut ClickButtonMyAvaFooter()
        {
            _driver.FindElement(_buttonMyAvaFooter).Click();
        }
        public LogOut ClickNextButton()
        {
            _driver.FindElement(_buttonLodOutAcc).Click();
        }
        public void ClickOnFinishRegistration() => _driver.FindElement(_buttonLogIn).Click();
    }
}
