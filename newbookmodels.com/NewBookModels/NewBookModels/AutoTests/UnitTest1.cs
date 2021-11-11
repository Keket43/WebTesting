using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace NewBookModels
{
    //public class Tests
    //{
    //    IWebDriver driver;       

    //    [SetUp]
    //    public void Setup()
    //    {
    //        driver = new ChromeDriver();
    //        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    //        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
    //        driver.Navigate().GoToUrl("https://newbookmodels.com/");
    //        driver.Manage().Window.Maximize();           
    //    }

    //    [TearDown]
    //    public void TearDown()
    //    {
    //        driver.Dispose();
    //    }
        //[Test]
        //public void LoginWithWrongCredential()
        //{
        //    var signInPage = new SignInPage(_webDriver);
        //    signInPage.GoToSignInPage()
        //        .InputEmailField("wrongEmail@gmail.com")
        //        .InputPasswordField("nzdfnzfdnxf")
        //        .ClickLoginButton();

        //    var actualResultMessage = signInPage.GetErrorMessage();

        //    Assert.AreEqual(expected: "Please enter a correct email and password.", actualResultMessage);

        //}

        //[Test]
        //public void Registration()
        //{
        //    IWebElement buttonSignUp = driver.FindElement(By.CssSelector("[class = Navbar__signUp--12ZDV]"));
        //    buttonSignUp.Click();

        //    IWebElement field1Name = driver.FindElement(By.CssSelector("[name= first_name]"));
        //    field1Name.SendKeys("Pan");
        //    IWebElement fieldLastName = driver.FindElement(By.CssSelector("[name= last_name]"));
        //    fieldLastName.SendKeys("Juchek");

        //    //DateTime dataTime = new DateTime();
        //    //dataTime = DateTime.Now;
        //    //string name = dataTime.ToString();
        //    //name = name.Replace("/", "");
        //    //name = name.Replace(" ", "");
        //    //name = name.Replace(":", "");
        //    //name = "newMail" + name + "@fake.com";

        //    //можно сделать так, короче и красивее:
        //    string now = DateTime.Now.ToString("ddMMyyyyhhmmss");
        //    string name = now + "@fake.com";


          
        //    IWebElement fieldEmail = driver.FindElement(By.CssSelector("[name=email]"));
        //    fieldEmail.SendKeys(name);

        //    IWebElement fieldPassword = driver.FindElement(By.CssSelector("[name=password]"));
        //    fieldPassword.SendKeys("Qwerty123!");

        //    IWebElement fieldConfirmPassword = driver.FindElement(By.CssSelector("[name=password_confirm]"));
        //    fieldConfirmPassword.SendKeys("Qwerty123!");

        //    IWebElement fieldMobile = driver.FindElement(By.CssSelector("[name=phone_number]"));
        //    fieldMobile.SendKeys("666.666.1312");

        //    IWebElement buttonNext = driver.FindElement(By.CssSelector("[type=submit]"));
        //    buttonNext.Click();

        //    IWebElement fieldCompanyName = driver.FindElement(By.CssSelector("[name=company_name]"));
        //    fieldCompanyName.SendKeys("Shopopalo");
        //    IWebElement fieldCompanyURL = driver.FindElement(By.CssSelector("[name=company_website]"));
        //    fieldCompanyURL.SendKeys("Shopopalo.fake.ua");

        //    string companyLocation = "2453 Lombard St, San Francisco, CA 94123, USA";
        //    IWebElement fieldAddress = driver.FindElement(By.CssSelector("input[name=\"location\"]"));
        //    fieldAddress.SendKeys(companyLocation.ToString());
        //    Thread.Sleep(1500);
        //    fieldAddress.SendKeys(Keys.ArrowDown);
        //    Thread.Sleep(500);
        //    fieldAddress.SendKeys(Keys.Enter);

        //    IWebElement buttonIndustry = driver.FindElement(By.CssSelector("[name=industry]"));
        //    buttonIndustry.Click();
        //    Thread.Sleep(1500);
        //    buttonIndustry.SendKeys(Keys.ArrowDown);
        //    Thread.Sleep(500);
        //    buttonIndustry.SendKeys(Keys.Enter);

        //    //IWebElement buttonFinish = driver.FindElement(By.CssSelector("[type=submit]"));
        //    //buttonFinish.Click();

        //    //Thread.Sleep(1500);

        //    ////проверка, сравниваем УРЛ
        //    //string actualResultURL = driver.Url;
        //    //Assert.AreEqual("https://newbookmodels.com/explore", actualResultURL);
        //}

        //[Test]
        //public void Authorization()
        //{
        //    IWebElement buttonLogInFooter = driver.FindElement(By.CssSelector("[class=\"Navbar__navLink--3lL7S Navbar__navLinkSingle--3x6Lx Navbar__login--28b35 \"]"));
        //    buttonLogInFooter.Click();

        //    IWebElement fieldEmailAdress = driver.FindElement(By.CssSelector("[class=\"Input__input--_88SI Input__themeNewbook--1IRjd Input__fontRegular--2SStp\"]"));
        //    fieldEmailAdress.SendKeys("newMail02112021230109@fake.com");

        //    IWebElement fieldPassword = driver.FindElement(By.CssSelector("[name=password]"));
        //    fieldPassword.SendKeys("Qwerty123!");

        //    IWebElement buttonLogIn = driver.FindElement(By.CssSelector("[type=submit]"));
        //    buttonLogIn.Click();

        //    Assert.Pass();
        //}

    //    [Test]
    //    public void LogOut()
    //    {
    //        IWebElement buttonLogInFooter = driver.FindElement(By.CssSelector("[class=\"Navbar__navLink--3lL7S Navbar__navLinkSingle--3x6Lx Navbar__login--28b35 \"]"));
    //        buttonLogInFooter.Click();

    //        IWebElement fieldEmailAdress = driver.FindElement(By.CssSelector("[class=\"Input__input--_88SI Input__themeNewbook--1IRjd Input__fontRegular--2SStp\"]"));
    //        fieldEmailAdress.SendKeys("newMail02112021230109@fake.com");

    //        IWebElement fieldPassword = driver.FindElement(By.CssSelector("[name=password]"));
    //        fieldPassword.SendKeys("Qwerty123!");

    //        IWebElement buttonLogIn = driver.FindElement(By.CssSelector("[type=submit]"));
    //        buttonLogIn.Click();

    //        IWebElement buttonMyAvaFooter = driver.FindElement(By.CssSelector("[class=\"AvatarClient__avatar--3TC7_\"]"));
    //        buttonMyAvaFooter.Click();

    //        IWebElement buttonLodOutAcc = driver.FindElement(By.CssSelector("[class=\"link link_type_logout link_active\"]"));
    //        buttonLodOutAcc.Click();

    //        Assert.Pass();
    //    }

    //    [TearDown]
    //    public void After()
    //    {
    //        driver.Quit();
    //    }
    //}
}