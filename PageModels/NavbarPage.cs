using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowBdd.PageModels
{
    public class NavbarPage
    {
        private IWebDriver _driver;
        public NavbarPage(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Private Locators
        private By _linkProductList = By.LinkText("Product List");
        private By _linkWatchList = By.LinkText("Watch List");
        private By _linkContact = By.LinkText("Contact");
        #endregion

        #region Actions
        public void GoToProductList() => _driver.FindElement(_linkProductList).Click();
        public void GoToWatchList() => _driver.FindElement(_linkWatchList).Click();
        public void GoToContact() => _driver.FindElement(_linkContact).Click();
        #endregion
    }
}
