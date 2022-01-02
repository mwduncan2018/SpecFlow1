using System;
using SpecFlowBdd.Drivers;
using SpecFlowBdd.PageModels;
using SpecFlowBdd.TestData.Product;
using SpecFlowBdd.TestData.WatchListEntry;
using TechTalk.SpecFlow;

namespace SpecFlowBdd.Hooks
{
    [Binding]
    //[Scope(Feature = "Feature name goes here")]
    public sealed class Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario(Order = 1)]
        public void BeforeScenario()
        {
            _scenarioContext.Add("pages", new Pages(new DriverProvider().GetDriver()));
            ((Pages)_scenarioContext["pages"]).OpenApp();
        }

        [AfterScenario(Order = 1)]
        public void DeleteScenarioTestData()
        {
            var pages = (Pages)_scenarioContext["pages"];
            try
            {
                var product = (Product)_scenarioContext["product"];
                pages.NavbarPage.GoToProductList();
                if (pages.ProductListPage.IsProductDisplayedInTable(product))
                {
                    pages.ProductListPage.Delete(product);
                    pages.ProductDeletePage.ConfirmDelete();
                }
            }
            catch (Exception) { }

            try
            {
                var entry = (WatchListEntry)_scenarioContext["entry"];
                pages.NavbarPage.GoToWatchList();
                if (pages.WatchListPage.IsEntryDisplayedInTable(entry))
                {
                    pages.WatchListPage.Delete(entry);
                    pages.WatchListDeletePage.ConfirmDelete();
                }
            }
            catch (Exception) { }
        }
        [AfterScenario(Order = 2)]
        public void AfterScenario()
        {
            var pages = (Pages)_scenarioContext["pages"];

            pages.Driver.Close();
            pages.Driver.Dispose();
        }




        /*
        [BeforeTestRun]
        public void BeforeTestRun()
        {
            //?
        }

        [AfterTestRun]
        public void DeleteAllTestData()
        {
            var pages = new Pages(new DriverProvider().GetDriver());
            pages.NavbarPage.GoToProductList();
            foreach (var product in new ProductProvider().GetAllProducts())
            {
                if (pages.ProductListPage.IsProductDisplayedInTable(product))
                {
                    pages.ProductListPage.Delete(product);
                    pages.ProductDeletePage.ConfirmDelete();
                }
            }

            var entries = new WatchListEntryProvider().GetAllEntries();
            foreach (var entry in entries)
            {

            }
        }
        */
    }
}
