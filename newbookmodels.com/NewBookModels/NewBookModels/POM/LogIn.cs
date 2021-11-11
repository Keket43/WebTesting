using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        //в классе писали:
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

        // Pan Juchek Qwerty123! Qwerty123!  666.666.1312
        // hf679jn@email.com  14881488wp
        //Shopopalo Shopopalo.fake.ua  2453 Lombard St, San Francisco, CA 94123, USA



        [Test]
        public void LoginWithValidLoginAndPass()
        {
            var signInPage = new SignInPage(_driver);
            var welcome = new WelcomePage(_driver);
            signInPage.GoToSignInPage()
                .InputEmailField("hf679jn@email.com")
                .InputPasswordField("14881488wp")
                .ClickLoginButton();
            var actualResultMessage = welcome.CheckTryLogIn;
            Assert.AreEqual(expected: "Welcome Pan! How can we help?", actualResultMessage);

        }
    }
}
