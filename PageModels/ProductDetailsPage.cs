using FluentAssertions;
using OpenQA.Selenium;
using SpecFlowBdd.TestData.Product;

namespace SpecFlowBdd.PageModels
{
    public class ProductDetailsPage
    {
        private IWebDriver _driver;

        public ProductDetailsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Locators
        private By _detailManufacturer = By.CssSelector("dl.row dd:nth-child(2)");
        private By _detailModel = By.CssSelector("dl.row dd:nth-child(4)");
        private By _detailPrice = By.CssSelector("dl.row dd:nth-child(6)");
        private By _detailNumberInStock = By.CssSelector("dl.row dd:nth-child(8)");
        #endregion

        #region Verification Actions
        public void VerifyDetailsAreDisplayedFor(Product product)
        {
            _driver.FindElement(_detailManufacturer).Text.Should().Be(product.Manufacturer);
            _driver.FindElement(_detailModel).Text.Should().Be(product.Model);
            _driver.FindElement(_detailPrice).Text.Should().Be(product.Price.ToString());
            _driver.FindElement(_detailNumberInStock).Text.Should().Be(product.NumberInStock.ToString());
        }
        #endregion
    }
}