using NUnit.Framework;
using OpenQA.Selenium;
using SpecflowAutoTestProject.PageObjects;
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
        
        [Given(@"User have navigated to Amazon website")]
        public void GivenUserHaveNavigatedToAmazonWebsite()
        {
            _homePageObj.NavigateToApplication();
        }

        [When(@"User press the search button")]
        public void WhenUserPressTheSearchButton()
        {
            _searchPageObj.ClickSearchButton();
        }

        [When(@"User select (.*) from list")]
        public void WhenUserSelectProductFromList(string productName)
        {
            Thread.Sleep(1000);
            _searchPageObj.SelectProductFromList(productName);
        }

        [When(@"User click add to cart button")]
        public void WhenUserClickAddToCartButton()
        {
            _addToCartObj.ClickAddToCartButton();
        }

        [Then(@"User validate added item (.*) is present in the shopping cart")]
        public void ThenUserValidateAddedItemIsPresentInTheShoppingCart(string productName)
        {
            string addedProduct = _addToCartObj.VerifyProductIsAddedIntoCart();
            Assert.AreEqual(addedProduct, productName);

        }
    }
}
