using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace SpecflowAutoTestProject.Utility
{
    public class SeKeywords 
    {
        private IWebDriver _webDriver;

        public SeKeywords(IWebDriver webDriver)
        {
            this._webDriver = webDriver;
        }
        public Boolean IsElementPresent(IWebElement element)
        {
            Boolean result = false;
            try
            {
                var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(2));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("search")));
                result = true;
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e.Message);   
            }
            return result;
        }

        public void ImplicitWaitFn(double Value)
        {
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Value);
        }

        public void ExplicitWaitFn(By Element,int Value)
        {
            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(Value));
            wait.Until(ExpectedConditions.ElementIsVisible(Element));
        }
        
        public static void SelectElementFromWebPage(IWebElement searchProductDiv,By productList,string value)
        {
           IList<IWebElement> options;
            try
            {
                IWebElement ul = searchProductDiv;
                options = ul.FindElements(productList);
                foreach (IWebElement option in options)
                {
                    if (value.Contains(option.Text))
                    {
                        option.Click();
                        break;
                    }
                }
            }
            catch (TimeoutException e)
            {
                Console.Write(e.Message);
            }
        }
        public void SelectElementFromList(IWebElement hamburgerMenuItem,By menuListItems, string value)
        {
            IList<IWebElement> options;
            try
            {
                IWebElement ul = hamburgerMenuItem;
                options = ul.FindElements(menuListItems);
                foreach (IWebElement option in options)
                {
                    if (value.Equals(option.Text))
                    {
                        option.Click(); 
                        break;
                    }
                }
            }
            catch (TimeoutException e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
