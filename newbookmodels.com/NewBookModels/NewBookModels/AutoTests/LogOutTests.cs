using System;
using NewBookModels.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NewBookModels.AutoTests
{
    class LogOutTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            _driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Dispose();
        }
        
        public void CheckTryLogOut()
        {
            var signInPage = new SignInPage(_driver);
            var welcome = new WelcomePage(_driver);
            signInPage.GoToSignInPage()
                .InputEmailField("Shopopalo.fake.ua")
                .InputPasswordField("Qwerty123!")
                .ClickLoginButton();
            var accountSetting = new Account(_driver);
            accountSetting.GoToAcc()
                .ButtonLogOut();
            var actualResultMessage = signInPage.SignInPageVerif();
            Assert.AreEqual(expected: "Client Sign In", actualResultMessage);
        }
    }
}
