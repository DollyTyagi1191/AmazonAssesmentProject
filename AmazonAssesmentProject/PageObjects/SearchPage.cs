﻿

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowAutoTestProject.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowAutoTestProject.PageObjects
{    
    public class SearchPage 
    {
        private IWebDriver _webDriver;
        public SearchPage(IWebDriver webDriver)
        {
            this._webDriver = webDriver;
        }

        //Finding web elements 
        private IWebElement SearchInput => _webDriver.FindElement(By.Id("twotabsearchtextbox"));
        private IWebElement SearchButton => _webDriver.FindElement(By.Id("nav-search-submit-button"));
        private IWebElement SearchResultText => _webDriver.FindElement(By.XPath("//span[contains(@class,'a-color-state')]"));
        private IWebElement SearchProduct => _webDriver.FindElement(By.XPath("//div[@class='s-main-slot s-result-list s-search-results sg-row']"));
            
        public void EnterSearchKeyword(string searchProduct)
        { 
            SearchInput.SendKeys(searchProduct);
        }
        public void ClickSearchButton()
        {
            SearchButton.Click();
        }
        public string GetSearchResult()
        {
            string searchedProduct = SearchResultText.Text.Replace("\"","");
            return searchedProduct;
        }
        public void SelectProductFromList(string firstProduct)
        {
            SeKeywords.SelectElementFromWebPage(SearchProduct, firstProduct);
        }
    }
}
