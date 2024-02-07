using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowAutoTestProject.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace AmazonAssesmentProject
{
    [Binding]
    public class ProductAddToCartStepDefinitions : TestBase
    {
        SearchPage _searchPageObj;
        HomePage _homePageObj;
        AddToCartPage _addToCartObj;
        private IWebDriver _webDriver;
      
        public ProductAddToCartStepDefinitions()
        {
            this._webDriver = GetWebDriver;
            _homePageObj = new HomePage(this._webDriver);
            _searchPageObj=new SearchPage(this._webDriver);
            _addToCartObj=new AddToCartPage(this._webDriver);
        }
        private const string AmazonUrl = "https://www.amazon.in";
        
        [Given(@"I have navigated to Amazon website")]
        public void GivenIHaveNavigatedToAmazonWebsite()
        {
            _homePageObj.NavigateToApplication();
        }

        [When(@"I press the search button")]
        public void WhenIPressTheSearchButton()
        {
            _searchPageObj.ClickSearchButton();
        }

        [When(@"I select (.*) from list")]
        public void WhenISelectProductFromList(string productName)
        {
            _searchPageObj.SelectProductFromList(productName);
        }

        [When(@"I click add to cart button")]
        public void WhenIClickAddToCartButton()
        {
            _addToCartObj.ClickAddToCartButton();
        }

        [Then(@"I validate added item is present in the shopping cart")]
        public void ThenIValidateAddedItemIsPresentInTheShoppingCart()
        {
            string addToCart = _addToCartObj.VerifyProductIsAdded();
            Assert.AreEqual(addToCart, "Added to Cart");
        }
    }
}
