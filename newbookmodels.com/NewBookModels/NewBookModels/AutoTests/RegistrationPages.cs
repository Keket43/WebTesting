using OpenQA.Selenium;
using System;

namespace NewBookModels.AutoTests
{
    internal class RegistrationPages
    {
        private IWebDriver driver;

        public RegistrationPages(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal object GoToRegistrationPages()
        {
            throw new NotImplementedException();
        }
    }
}