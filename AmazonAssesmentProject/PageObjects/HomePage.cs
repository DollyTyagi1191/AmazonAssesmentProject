using AmazonAssesmentProject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowAutoTestProject.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowAutoTestProject.PageObjects
{
    public class HomePage 
    {
        private IWebDriver _webDriver;
        SeKeywords _SelKeywordObj;
        private const string AmazonUrl = "https://amazon.in";
        public HomePage(IWebDriver webDriver)
        {
            this._webDriver = webDriver;
            _SelKeywordObj = new SeKeywords(this._webDriver);

        }
        //Finding web elements 
        private IWebElement AmazonLogo => _webDriver.FindElement(By.Id("nav-logo-sprites"));

        public void NavigateToApplication()
        {
            _SelKeywordObj.ImplicitWaitFn(20);
            _webDriver.Navigate().GoToUrl(AmazonUrl);
        }
        public Boolean VerifyAmazonLogo()
        {
            return _SelKeywordObj.IsElementPresent(AmazonLogo);
        }
    }
}
