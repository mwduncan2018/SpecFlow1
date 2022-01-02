using OpenQA.Selenium;
using SpecFlowBdd.TestData.WatchListEntry;

namespace SpecFlowBdd.PageModels
{
    public class WatchListEditPage
    {
        private IWebDriver _driver;

        public WatchListEditPage(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Locators
        private By _inputManufacturer = By.Id("Manufacturer");
        private By _inputModel = By.Id("Model");
        private By _btnAdd = By.CssSelector(".form-group input[value='Save']");
        #endregion

        #region Actions
        public void Edit(WatchListEntry entry)
        {
            _driver.FindElement(_inputManufacturer).Clear();
            _driver.FindElement(_inputManufacturer).SendKeys(entry.Manufacturer);
            _driver.FindElement(_inputModel).Clear();
            _driver.FindElement(_inputModel).SendKeys(entry.Model);
            _driver.FindElement(_btnAdd).Submit();
        }
        #endregion

    }
}