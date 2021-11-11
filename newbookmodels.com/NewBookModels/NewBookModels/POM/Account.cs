using OpenQA.Selenium;


namespace NewBookModels.POM
{
    class Account
    {
        private IWebDriver _driver;

        private readonly By _goToAcc = By.CssSelector("[class='MainHeader__staticItemAvatar--3LwWp MainHeader__staticItem--2UY1x ']");
        private readonly By _logOut = By.CssSelector("[class='link link_type_logout link_active']");

        public Account(IWebDriver webDriver)
        {
            _driver = webDriver;
        }
       
        public Account GoToAcc()
        {
            _driver.FindElement(_goToAcc).Click();
            return this;
        }
        public void ButtonLogOut()
        {
            _driver.FindElement(_logOut).Click();
        }
    }
}
