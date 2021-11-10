using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBookModels.POM
{
    class Authorization
    {
        private readonly IWebDriver _driver;

        private readonly By _fieldEmail = By.CssSelector("[name=email]");
        private readonly By _fieldPassword = By.CssSelector("[name=password]");

        //IWebElement buttonLogInFooter = driver.FindElement(By.CssSelector("[class=\"Navbar__navLink--3lL7S Navbar__navLinkSingle--3x6Lx Navbar__login--28b35 \"]"));
        //buttonLogInFooter.Click();

        //    IWebElement fieldEmailAdress = driver.FindElement(By.CssSelector("[class=\"Input__input--_88SI Input__themeNewbook--1IRjd Input__fontRegular--2SStp\"]"));
        //fieldEmailAdress.SendKeys("newMail02112021230109@fake.com");

        //    IWebElement fieldPassword = driver.FindElement(By.CssSelector("[name=password]"));
        //fieldPassword.SendKeys("Qwerty123!");

        //    IWebElement buttonLogIn = driver.FindElement(By.CssSelector("[type=submit]"));
        //buttonLogIn.Click();

        public Authorization(IWebDriver webDriver)
        {
            _driver = webDriver;
        }

        public Authorization GoToRegistrationPages()
        {
            _driver.Navigate().GoToUrl("https://newbookmodels.com/");
            _driver.FindElement(_buttonSignUp).Click();
            return this;
        }

        public RegistrationPage InputFirstName(string firstName)
        {
            _driver.FindElement(_field1Name).SendKeys(firstName);
            return this;
        }

    }
}
