using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBookModels
{
    public class Helper
    {
        public static string GenEmail()
        {    
            return DateTime.Now.ToString("ddMMyyyyhhmmss") + "@fake.com";
        }
    }
}
