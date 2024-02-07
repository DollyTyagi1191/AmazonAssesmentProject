using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AmazonAssesmentProject
{
    public class TestBase
    {
        private static IWebDriver _webDriver;
       
        public static IWebDriver GetWebDriver
        {
            get { return _webDriver; }   
            set { _webDriver =  value; }
        }

    }
}
