using OpenQA.Selenium;
using SpecFlowBdd.TestData.Product;

namespace SpecFlowBdd.PageModels
{
    public class ProductEditPage
    {
        private IWebDriver _driver;

        public ProductEditPage(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Locators
        private By _inputManufacturer = By.Id("Manufacturer");
        private By _inputModel = By.Id("Model");
        private By _inputPrice = By.Id("Price");
        private By _inputNumberInStock = By.Id("NumberInStock");
        private By _btnAdd = By.CssSelector(".form-group input[value='Save']");
        #endregion

        #region Actions
        public void Edit(Product product)
        {
            _driver.FindElement(_inputManufacturer).Clear();
            _driver.FindElement(_inputManufacturer).SendKeys(product.Manufacturer);
            _driver.FindElement(_inputModel).Clear();
            _driver.FindElement(_inputModel).SendKeys(product.Model);
            _driver.FindElement(_inputPrice).Clear();
            _driver.FindElement(_inputPrice).SendKeys(product.Price.ToString());
            _driver.FindElement(_inputNumberInStock).Clear();
            _driver.FindElement(_inputNumberInStock).SendKeys(product.NumberInStock.ToString());
            _driver.FindElement(_btnAdd).Submit();
        }
        #endregion
    }
}