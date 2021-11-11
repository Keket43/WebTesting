using OpenQA.Selenium;
using System.Threading;

namespace NewBookModels.POM
{
    class RegistrationPage
    {
        private readonly IWebDriver _driver;

        private readonly By _buttonSignUp = By.CssSelector("[class = Navbar__signUp--12ZDV]");
        private readonly By _field1Name = By.CssSelector("[name = first_name]");
        private readonly By _fieldLastName = By.CssSelector("[name = last_name]");
        private readonly By _fieldEmail = By.CssSelector("[name=email]");
        private readonly By _fieldPassword = By.CssSelector("[name=password]");
        private readonly By _fieldConfirmPassword = By.CssSelector("[name=password_confirm]");
        private readonly By _fieldMobile = By.CssSelector("[name=phone_number]");
        private readonly By _buttonNext = By.CssSelector("[type=submit]");
        private readonly By _fieldCompanyName = By.CssSelector("[name=company_name]");
        private readonly By _fieldCompanyURL = By.CssSelector("[name=company_website]");
        private readonly By _companyLocation = By.CssSelector("input[name=\"location\"]");
        private readonly By _buttonIndustry = By.CssSelector("[name=industry]");       
        private readonly By _buttonFinish = By.CssSelector("[type=submit]");

        private readonly By _errorFor1Name = By.XPath("//div[@class='SignupFormLayout__fieldRow--bGt25']//input[@name='first_name']/../div[@class = 'FormErrorText__error---nzyq']");
        private readonly By _errorForLastName = By.XPath("//div[@class='SignupFormLayout__fieldRow--bGt25']//input[@name='last_name']/../div[@class = 'FormErrorText__error---nzyq']");
        
        public RegistrationPage(IWebDriver webDriver)
        {
            _driver = webDriver;
        }
        
        public RegistrationPage GoToRegistrationPages()
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

        public RegistrationPage InputLastName(string lastName)
        {
            _driver.FindElement(_fieldLastName).SendKeys(lastName);
            return this;
        }

        public RegistrationPage InputEmail(string mail)
        {
            _driver.FindElement(_fieldEmail).SendKeys(mail);
            return this;
        }

        public RegistrationPage InputPassword(string paswd)
        {
            _driver.FindElement(_fieldPassword).SendKeys(paswd);
            return this;
        }

        public RegistrationPage InputConfirmPassword(string paswd)
        {
            _driver.FindElement(_fieldConfirmPassword).SendKeys(paswd);
            return this;
        }

        public RegistrationPage InputPhoneNumber(string number)
        {
            _driver.FindElement(_fieldMobile).SendKeys(number);
            return this;
        }

        public void ClickNextButton()
        {
            _driver.FindElement(_buttonNext).Click();
        }

        public RegistrationPage InputCompanyName(string number)
        {
            _driver.FindElement(_fieldCompanyName).SendKeys(number);
            return this;
        }        

        public RegistrationPage InputCompanyWebSite(string number)
        {
            _driver.FindElement(_fieldCompanyURL).SendKeys(number);
            return this;
        }

        public RegistrationPage InputOtherIndustry(string number)
        {
            _driver.FindElement(_companyLocation).SendKeys(number);
            return this;
        }

        public RegistrationPage InputCompanyAddress(string address)
        {
            _driver.FindElement(_companyLocation).SendKeys(address);
            Thread.Sleep(2000);
            _driver.FindElement(_companyLocation).SendKeys(Keys.ArrowDown);
            Thread.Sleep(1000);
            _driver.FindElement(_companyLocation).SendKeys(Keys.Enter);
            return this;
        }

        public RegistrationPage InputCompanyIndustry(int i)
        {
            _driver.FindElement(_buttonIndustry).Click();
            Thread.Sleep(2000);
            for (int counter = 0; counter < i; counter++)
            {
                _driver.FindElement(_buttonIndustry).SendKeys(Keys.ArrowDown);
            }
            Thread.Sleep(1000);
            _driver.FindElement(_buttonIndustry).SendKeys(Keys.Enter);
            return this;
        }               
        
        public void ClickOnFinishRegistration() => _driver.FindElement(_buttonFinish).Click();

        public string ErrorTextFor1Name() => _driver.FindElement(_errorBy1Name).Text;

        public string ErrorTextForLastName() => _driver.FindElement(_errorByLastName).Text;
    }


}
