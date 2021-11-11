using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBookModels.POM
{
    public class GenerateEmail
    {
        public string GenEmail()
        {  
            private IWebDriver _driver;
            
            //DateTime dataTime = new DateTime();
            //    //dataTime = DateTime.Now;
            //    //string name = dataTime.ToString();
            //    //name = name.Replace("/", "");
            //    //name = name.Replace(" ", "");
            //    //name = name.Replace(":", "");
            //    //name = "newMail" + name + "@fake.com";

            //можно сделать так, короче и красивее:
            public string genEmail = DateTime.Now.ToString("ddMMyyyyhhmmss" + "@fake.com");
            //string name = now + "@fake.com";
        }
    }
}
