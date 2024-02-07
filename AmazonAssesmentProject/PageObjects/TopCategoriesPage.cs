using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecflowAutoTestProject.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace SpecflowAutoTestProject.PageObjects
{
    public class TopCategoriesPage 
    {
        private IWebDriver _webDriver;
        SeKeywords _SelKeywordObj;
        public TopCategoriesPage(IWebDriver webDriver)
        {
            this._webDriver = webDriver;
            _SelKeywordObj = new SeKeywords(this._webDriver);
        }

        //Finding web elements 
        private IWebElement hamburgerMenuPanel => _webDriver.FindElement(By.Id("nav-hamburger-menu"));
        private IWebElement hamburgerMenuItem => _webDriver.FindElement(By.XPath("//ul[@class='hmenu hmenu-visible']"));
        private IWebElement panelItem => _webDriver.FindElement(By.XPath("//ul[@class='hmenu hmenu-visible hmenu-translateX']//a[text()=' Software ']"));
        private IWebElement OfficeLogo => _webDriver.FindElement(By.XPath("//img[@alt='Office']"));
        private IWebElement ELearning => _webDriver.FindElement(By.XPath("//img[@alt='Elearning']"));

        public void ClickHamburgerMenuButton()
        {
            hamburgerMenuPanel.Click();
            _SelKeywordObj.ExplicitWaitFn(By.Id("nav-hamburger-menu"), 20);
        }
        public void SelectHamburgerMenuOption(string itemValue)
        {
            _SelKeywordObj.ExplicitWaitFn(By.Id("nav-hamburger-menu"), 20);
            _SelKeywordObj.SelectElementFromList(hamburgerMenuItem, itemValue);
            Thread.Sleep(1000);
        }
        public void ClickSoftware()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_webDriver;
            js.ExecuteScript("arguments[0].click();", panelItem);
        }

        public Boolean VerifyTopCategoriesLogo()
        {
            Boolean officeLogo = OfficeLogo.Displayed;
            Boolean eLearning = ELearning.Displayed;
            if (officeLogo == true && eLearning == true) return true;
            else return false;
            
        }
    }
}
