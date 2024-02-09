using NUnit.Framework;
using OpenQA.Selenium;
using SpecflowAutoTestProject.PageObjects;
using TechTalk.SpecFlow;

namespace AmazonAssesmentProject
{
    [Binding]
    public class VerifyLogoTopCategoriesStepDefinitions : TestBase
    {
        TopCategoriesPage _topCategoryPageObject;
        private IWebDriver _webDriver;
        public VerifyLogoTopCategoriesStepDefinitions()
        {
            this._webDriver = GetWebDriver;
            _topCategoryPageObject = new TopCategoriesPage(this._webDriver);
        }
        
        [Given(@"User have selected hamburger menu button from the navigation bar")]
        public void GivenUserHaveSelectedHamburgerMenuButtonFromTheNavigationBar()
        {
            _topCategoryPageObject.ClickHamburgerMenuButton();
        }

        [When(@"User select (.*) options")]
        public void WhenUserSelectMobilesComputersOptions(string menuItem)
        {
            Thread.Sleep(1000);
            _topCategoryPageObject.SelectHamburgerMenuOption(menuItem);
        }

        [When(@"User select Software option")]
        public void WhenUserSelectSoftwareOption()
        {
            _topCategoryPageObject.ClickSoftware();
        }

        [Then(@"User validate logo is present under Top categories section")]
        public void ThenUserValidateLogoIsPresentUnderTopCategoriesSection()
        {
            Assert.IsTrue(_topCategoryPageObject.VerifyTopCategoriesLogo());
        }
    }
}
