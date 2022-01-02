using OpenQA.Selenium;
using SpecFlowBdd.TestData.Product;

namespace SpecFlowBdd.PageModels
{
    public class ProductAddPage
    {
        private IWebDriver _driver;
        public ProductAddPage(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Locators
        private By _inputManufacturer = By.Id("Manufacturer");
        private By _inputModel = By.Id("Model");
        private By _inputPrice = By.Id("Price");
        private By _inputNumberInStock = By.Id("NumberInStock");
        private By _btnAdd = By.CssSelector(".form-group input[value='Add']");
        #endregion

        #region Actions
        public void AddProduct(Product product)
        {
            _driver.FindElement(_inputManufacturer).SendKeys(product.Manufacturer);
            _driver.FindElement(_inputModel).SendKeys(product.Model);
            _driver.FindElement(_inputPrice).SendKeys(product.Price.ToString());
            _driver.FindElement(_inputNumberInStock).SendKeys(product.NumberInStock.ToString());
            _driver.FindElement(_btnAdd).Submit();
        }
        #endregion
    }
}
