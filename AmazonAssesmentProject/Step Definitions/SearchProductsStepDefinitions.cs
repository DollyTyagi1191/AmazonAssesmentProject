using NUnit.Framework;
using OpenQA.Selenium;
using SpecflowAutoTestProject.PageObjects;
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

        [Given(@"User have entered (.*) in search input")]
        public void GivenUserHaveEnteredKeywordInSearchInput(string searchProduct)
        {
            _searchPageObject.EnterSearchKeyword(searchProduct);
        }

        [Then(@"User validate Amazon logo in top left corner")]
        public void ThenUserValidateAmazonLogoInTopLeftCorner()
        {
            Boolean actualResult = _homePageObject.VerifyAmazonLogo();
            Assert.IsTrue(actualResult);
        }

        [Then(@"User validate (.*) in Search result info bar")]
        public void ThenUserValidateInSearchResultInfoBar(string expectedResult)
        {
            string actualResult = _searchPageObject.GetSearchResult();
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
