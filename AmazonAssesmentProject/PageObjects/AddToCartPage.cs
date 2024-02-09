using OpenQA.Selenium;
using SpecflowAutoTestProject.Utility;

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
        private IWebElement CartButton=> _webDriver.FindElement(By.XPath("//span[@id='attach-sidesheet-view-cart-button-announce' and contains(text(),'Cart')]"));
        private By addedTocartMsg=> By.XPath("//div[@id='attach-added-to-cart-message']//h4");
        private IWebElement addedProductNext=> _webDriver.FindElement(By.XPath("//span[contains(@class,'sc-product-title sc-grid-item-product-title')]//span[@class='a-truncate-cut']"));
        public void ClickAddToCartButton()
        {
            this._webDriver.SwitchTo().Window(this._webDriver.WindowHandles[1]);
            AddToCart.Click();
            Thread.Sleep(2000);
            _SelKeywordObj.ExplicitWaitFn(addedTocartMsg,40);
        }
        public string VerifyProductIsAddedIntoCart()
        {
            CartButton.Click();
            string AddedSuccessfully = addedProductNext.Text;
            return AddedSuccessfully;
        }

    }
}
