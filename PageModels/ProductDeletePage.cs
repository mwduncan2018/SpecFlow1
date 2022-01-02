using OpenQA.Selenium;

namespace SpecFlowBdd.PageModels
{
    public class ProductDeletePage
    {
        private IWebDriver _driver;

        public ProductDeletePage(IWebDriver driver)
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