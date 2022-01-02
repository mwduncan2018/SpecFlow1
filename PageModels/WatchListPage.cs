using FluentAssertions;
using OpenQA.Selenium;
using SpecFlowBdd.TestData.WatchListEntry;

namespace SpecFlowBdd.PageModels
{
    public class WatchListPage
    {
        private IWebDriver _driver;

        public WatchListPage(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Locators
        private By _btnAddNewEntry = By.LinkText("Add To Watch List");
        private By _tableRows = By.CssSelector("tbody tr");
        private By _tableManufacturer = By.CssSelector("td:nth-child(1)");
        private By _tableModel = By.CssSelector("td:nth-child(2)");
        private By _tableEdit = By.CssSelector("td:nth-child(3) a:nth-child(1)");
        private By _tableDetails = By.CssSelector("td:nth-child(3) a:nth-child(2)");
        private By _tableDelete = By.CssSelector("td:nth-child(3) a:nth-child(3)");
        #endregion

        #region Actions
        public void AddNewEntry() => _driver.FindElement(_btnAddNewEntry).Click();

        public void Edit(WatchListEntry entry)
        {
            foreach (var row in _driver.FindElements(_tableRows))
                if (row.FindElement(_tableManufacturer).Text == entry.Manufacturer
                    && row.FindElement(_tableModel).Text == entry.Model)
                {
                    row.FindElement(_tableEdit).Click();
                    return;
                }
        }

        public void Details(WatchListEntry entry)
        {
            foreach (var row in _driver.FindElements(_tableRows))
                if (row.FindElement(_tableManufacturer).Text == entry.Manufacturer
                    && row.FindElement(_tableModel).Text == entry.Model)
                {
                    row.FindElement(_tableDetails).Click();
                    return;
                }
        }

        public void Delete(WatchListEntry entry)
        {
            foreach (var row in _driver.FindElements(_tableRows))
                if (row.FindElement(_tableManufacturer).Text == entry.Manufacturer
                    && row.FindElement(_tableModel).Text == entry.Model)
                {
                    row.FindElement(_tableDelete).Click();
                    return;
                }
        }
        #endregion

        #region Conditional Actions
        public bool IsEntryDisplayedInTable(WatchListEntry entry)
        {
            var entryDisplayed = false;
            foreach (var row in _driver.FindElements(_tableRows))
            {
                if (row.FindElement(_tableManufacturer).Text == entry.Manufacturer
                    && row.FindElement(_tableModel).Text == entry.Model)
                {
                    entryDisplayed = true;
                }
            }
            return entryDisplayed;
        }
        #endregion

        #region Verification Actions
        public void VerifyEntryIsDisplayed(WatchListEntry entry) =>
            IsEntryDisplayedInTable(entry).Should().BeTrue();
        public void VerifyEntryIsNotDisplayed(WatchListEntry entry) =>
            IsEntryDisplayedInTable(entry).Should().BeFalse();
        #endregion


    }
}