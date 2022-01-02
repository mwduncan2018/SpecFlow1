using FluentAssertions;
using OpenQA.Selenium;
using SpecFlowBdd.TestData.WatchListEntry;

namespace SpecFlowBdd.PageModels
{
    public class WatchListDetailsPage
    {
        private IWebDriver _driver;

        public WatchListDetailsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Locators
        private By _detailManufacturer = By.CssSelector("dl.row dd:nth-child(2)");
        private By _detailModel = By.CssSelector("dl.row dd:nth-child(4)");
        #endregion

        #region Verification Actions
        public void VerifyDetailsAreDisplayedFor(WatchListEntry entry)
        {
            _driver.FindElement(_detailManufacturer).Text.Should().Be(entry.Manufacturer);
            _driver.FindElement(_detailModel).Text.Should().Be(entry.Model);
        }
        #endregion
    }
}