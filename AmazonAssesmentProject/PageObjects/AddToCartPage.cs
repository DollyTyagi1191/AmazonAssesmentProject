using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowAutoTestProject.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowAutoTestProject.PageObjects
{    
    public class AddToCartPage
    {
        private IWebDriver _webDriver;
        SeKeywords _SelKeywordObj;
        public AddToCartPage(IWebDriver webDriver)
        {
            this._webDriver = webDriver;
            _SelKeywordObj = new SeKeywords(this._webDriver);
        }

        //Finding web elements 
        private IWebElement AddToCart => _webDriver.FindElement(By.XPath("//input[@id='add-to-cart-button' and @type='submit']"));
        private IWebElement SuccessAlert => _webDriver.FindElement(By.XPath("//div[@id='attach-added-to-cart-message']//h4"));
        
        public void ClickAddToCartButton()
        {
            this._webDriver.SwitchTo().Window(this._webDriver.WindowHandles[1]);
            AddToCart.Click();
            Thread.Sleep(1000);
            _SelKeywordObj.ExplicitWaitFn(By.XPath("//div[@id='attach-added-to-cart-message']//h4"), 40);
        }
        public string VerifyProductIsAdded()
        {
            string AddedSuccessfully = SuccessAlert.Text;
            return AddedSuccessfully;
        }

    }
}
