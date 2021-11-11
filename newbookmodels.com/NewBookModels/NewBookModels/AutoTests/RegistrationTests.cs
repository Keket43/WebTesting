using System;
using NewBookModels.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NewBookModels;

namespace NewBookModels.AutoTests
{
    class RegistrationTests
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
        public void RegistrationWitfValidData()
        {  
            string name = "Pan";
            var registrationPage = new RegistrationPage(_driver);
            var welcome = new WelcomePage(_driver);
            registrationPage.GoToRegistrationPages()
                .InputFirstName(name)
                .InputLastName("Juchek")
                .InputEmail(Helper.GenEmail())
                .InputPassword("Qwerty123!")
                .InputConfirmPassword("Qwerty123!")
                .InputPhoneNumber("666.666.1312")
                .ClickNextButton();


            registrationPage.InputCompanyName("Shopopalo")
                .InputCompanyWebSite("Shopopalo.fake.ua")
                .InputCompanyAddress("2453 Lombard St, San Francisco, CA 94123, USA")
                .InputCompanyIndustry(3) //1-6 
                .ClickOnFinishRegistration();

            Assert.AreEqual(expected: $"Welcome {name}! How can we help?", welcome.CheckTryLogIn);
        }
        // Pan Juchek Qwerty123! Qwerty123!  666.666.1312
        //Shopopalo Shopopalo.fake.ua  2453 Lombard St, San Francisco, CA 94123, USA


        [TestCase("Pan", "", "Qwerty123!", "Qwerty123!", "6666661312")]
        public void RegistrationWithEmptyLastName(string firstName, string lastName, string password, string confirmPassword, string phone)
        {
            var registrationPage = new RegistrationPage(_driver);
            var welcome = new WelcomePage(_driver);
            registrationPage.GoToRegistrationPages()
                .InputFirstName(firstName)
                .InputLastName(lastName)
                .InputEmail(Helper.GenEmail())
                .InputPassword(password)
                .InputConfirmPassword(confirmPassword)
                .InputPhoneNumber(phone)
                .ClickNextButton();
            var actualResultat = registrationPage.ErrorTextAboutLastName();

            Assert.AreEqual(expected: "Required", actualResultat);
        }
    }
}
