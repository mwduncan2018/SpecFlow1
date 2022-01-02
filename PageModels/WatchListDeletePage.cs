using OpenQA.Selenium;

namespace SpecFlowBdd.PageModels
{
    public class WatchListDeletePage
    {
        private IWebDriver _driver;

        public WatchListDeletePage(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Locators
        private By _btnConfirmDelete = By.CssSelector("form input[value='Confirm Delete']");
        #endregion

        #region Actions
        public void ConfirmDelete() => _driver.FindElement(_btnConfirmDelete).Click();
        #endregion
    }
}