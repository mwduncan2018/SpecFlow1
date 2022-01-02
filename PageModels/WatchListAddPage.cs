using OpenQA.Selenium;
using SpecFlowBdd.TestData.WatchListEntry;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowBdd.PageModels
{
    public class WatchListAddPage
    {
        private IWebDriver _driver;
        public WatchListAddPage(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Locators
        private By _inputManufacturer = By.Id("Manufacturer");
        private By _inputModel = By.Id("Model");
        private By _btnAdd = By.CssSelector(".form-group input[value='Add']");
        #endregion

        #region Actions
        public void AddEntry(WatchListEntry entry)
        {
            _driver.FindElement(_inputManufacturer).SendKeys(entry.Manufacturer);
            _driver.FindElement(_inputModel).SendKeys(entry.Model);
            _driver.FindElement(_btnAdd).Submit();
        }
        #endregion
    }
}
