using FluentAssertions;
using OpenQA.Selenium;
using SpecFlowBdd.TestData.Product;

namespace SpecFlowBdd.PageModels
{
    public class ProductListPage
    {
        private IWebDriver _driver;

        public ProductListPage(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Locators
        private By _btnAddNewProduct = By.LinkText("Add New Product");
        private By _btnFuzzyMatching = By.Id("fuzzFuzz");
        private By _tableRows = By.CssSelector("tbody tr");
        private By _tableMatch = By.CssSelector("td:nth-child(1) > input");
        private By _tableManufacturer = By.CssSelector("td:nth-child(2)");
        private By _tableModel = By.CssSelector("td:nth-child(3)");
        private By _tablePrice = By.CssSelector("td:nth-child(4)");
        private By _tableNumberInStock = By.CssSelector("td:nth-child(5)");
        private By _tableEdit = By.CssSelector("td:nth-child(6) a:nth-child(1)");
        private By _tableDetails = By.CssSelector("td:nth-child(6) a:nth-child(2)");
        private By _tableDelete = By.CssSelector("td:nth-child(6) a:nth-child(3)");
        private By _tableFuzzyMatch = By.CssSelector("td:nth-child(7) > input");
        #endregion

        #region Actions
        public void AddNewProduct() => _driver.FindElement(_btnAddNewProduct).Click();

        public void EnableStandardMatching()
        {
            if (IsFuzzyMatchingEnabled())
                _driver.FindElement(_btnFuzzyMatching).Click();
        }

        public void EnableFuzzyMatching()
        {
            if (!IsFuzzyMatchingEnabled())
                _driver.FindElement(_btnFuzzyMatching).Click();
        }

        public void Edit(Product product)
        {
            foreach (var row in _driver.FindElements(_tableRows))
                if (row.FindElement(_tableManufacturer).Text == product.Manufacturer
                    && row.FindElement(_tableModel).Text == product.Model)
                {
                    row.FindElement(_tableEdit).Click();
                    return;
                }
        }

        public void Details(Product product)
        {
            foreach (var row in _driver.FindElements(_tableRows))
                if (row.FindElement(_tableManufacturer).Text == product.Manufacturer
                    && row.FindElement(_tableModel).Text == product.Model)
                {
                    row.FindElement(_tableDetails).Click();
                    return;
                }
        }

        public void Delete(Product product)
        {
            foreach (var row in _driver.FindElements(_tableRows))
                if (row.FindElement(_tableManufacturer).Text == product.Manufacturer
                    && row.FindElement(_tableModel).Text == product.Model)
                {
                    row.FindElement(_tableDelete).Click();
                    return;
                }
        }
        #endregion

        #region Conditional Actions
        public bool IsFuzzyMatchingEnabled()
        {
            return _driver.FindElement(_btnFuzzyMatching).Text == "Disable Fuzzy Matching!";
        }

        public bool IsProductDisplayedInTable(Product product)
        {
            var productDisplayed = false;
            foreach (var row in _driver.FindElements(_tableRows))
            {
                if (row.FindElement(_tableManufacturer).Text == product.Manufacturer
                    && row.FindElement(_tableModel).Text == product.Model
                    && row.FindElement(_tablePrice).Text == product.Price.ToString()
                    && row.FindElement(_tableNumberInStock).Text == product.NumberInStock.ToString())
                {
                    productDisplayed = true;
                }
            }
            return productDisplayed;
        }

        public bool IsProductAMatch(Product product)
        {
            var index = GetRowIndexOf(product);
            if (index is -1)
                return false;
            if (_driver.FindElements(_tableMatch)[index].GetAttribute("checked") == "true")
                return true;
            return false;
        }

        public bool IsProductAFuzzyMatch(Product product)
        {
            var index = GetRowIndexOf(product);
            if (index is -1)
                return false;
            var fuzzyMatches = _driver.FindElements(_tableFuzzyMatch);
            if (fuzzyMatches.Count is 0)
                return false;
            if (fuzzyMatches[index].GetAttribute("checked") == "true")
                return true;
            return false;
        }
        #endregion

        #region Get Actions
        public int GetRowIndexOf(Product product)
        {
            var rows = _driver.FindElements(_tableRows);
            for (int i = 0; i < rows.Count; i++)
                if (rows[i].FindElement(_tableManufacturer).Text == product.Manufacturer
                    && rows[i].FindElement(_tableModel).Text == product.Model)
                    return i;
            return -1;
        }
        #endregion

        #region Verification Actions
        public void VerifyProductIsDisplayed(Product product) => IsProductDisplayedInTable(product).Should().BeTrue();
        public void VerifyProductIsNotDisplayed(Product product) => IsProductDisplayedInTable(product).Should().BeFalse();
        public void VerifyProductIsAMatch(Product product) => IsProductAMatch(product).Should().BeTrue();
        public void VerifyProductIsAFuzzyMatch(Product product) => IsProductAFuzzyMatch(product).Should().BeTrue();
        public void VerifyProductIsNotAMatch(Product product)
        {
            IsProductAMatch(product).Should().BeFalse();
            IsProductAFuzzyMatch(product).Should().BeFalse();
        }
        #endregion
    }
}