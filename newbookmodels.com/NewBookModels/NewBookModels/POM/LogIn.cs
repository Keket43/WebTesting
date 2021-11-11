using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace NewBookModels.POM
{
    public class LogIn
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
       
        [Test]
        public void LoginWithWrongCredential()
        {
            var signInPage = new SignInPage(_driver);
            signInPage.GoToSignInPage()
                .InputEmailField("wrongEmail@gmail.com")
                .InputPasswordField("nzdfnzfdnxf")
                .ClickLoginButton();

            var actualResultMessage = signInPage.GetErrorMessage();

            Assert.AreEqual(expected: "Please enter a correct email and password.", actualResultMessage);
        }
        

        [Test]
        public void LoginWithValidLoginAndPass()
        {
            var signInPage = new SignInPage(_driver);
            var welcome = new WelcomePage(_driver);
            signInPage.GoToSignInPage()
                .InputEmailField("Shopopalo.fake.ua")
                .InputPasswordField("Qwerty123!")
                .ClickLoginButton();
            var actualResultMessage = welcome.CheckTryLogIn;
            Assert.AreEqual(expected: "Welcome Pan! How can we help?", actualResultMessage);
        }
    }
}
