using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowAutoTestProject.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace AmazonAssesmentProject
{
    [Binding]
    public class SearchProductsStepDefinitions : TestBase
    {

        SearchPage _searchPageObject;
        HomePage _homePageObject;
        private IWebDriver _webDriver;
        public SearchProductsStepDefinitions()
        {
            this._webDriver = GetWebDriver;
            _searchPageObject=new SearchPage(this._webDriver);
            _homePageObject=new HomePage(this._webDriver);
        }

        [Given(@"I have entered (.*) in search input")]
        public void GivenIHaveEnteredKeywordInSearchInput(string searchProduct)
        {
            _searchPageObject.EnterSearchKeyword(searchProduct);
        }

        [Then(@"I validate Amazon logo in top left corner")]
        public void ThenIValidateAmazonLogoInTopLeftCorner()
        {
            Boolean actualResult = _homePageObject.VerifyAmazonLogo();
            Assert.IsTrue(actualResult);
        }

        [Then(@"I validate (.*) in Search result info bar")]
        public void ThenIValidateInSearchResultInfoBar(string expectedResult)
        {
            string actualResult = _searchPageObject.GetSearchResult();
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
