using NUnit.Framework;
using OpenQA.Selenium;
using SpecflowAutoTestProject.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace AmazonAssesmentProject
{
    [Binding]
    public class VerifyLogoTopCategoriesStepDefinitions : TestBase
    {
       // private IWebDriver _webDriver;
        TopCategoriesPage _topCategoryPageObject;
        private IWebDriver _webDriver;
        public VerifyLogoTopCategoriesStepDefinitions()
        {
            this._webDriver = GetWebDriver;
            _topCategoryPageObject = new TopCategoriesPage(this._webDriver);
        }
        
        [Given(@"I have selected hamburger menu button from the navigation bar")]
        public void GivenIHaveSelectedHamburgerMenuButtonFromTheNavigationBar()
        {
            _topCategoryPageObject.ClickHamburgerMenuButton();
        }

        [When(@"I select (.*) options")]
        public void WhenISelectMobilesComputersOptions(string menuItem)
        {
            _topCategoryPageObject.SelectHamburgerMenuOption(menuItem);
        }

        [When(@"I select Software option")]
        public void WhenISelectSoftwareOption()
        {
            _topCategoryPageObject.ClickSoftware();
        }

        [Then(@"I validate logo is present under Top categories section")]
        public void ThenIValidateLogoIsPresentUnderTopCategoriesSection()
        {
            Assert.IsTrue(_topCategoryPageObject.VerifyTopCategoriesLogo());
        }
    }
}
