using SpecFlowBdd.PageModels;
using SpecFlowBdd.TestData.Product;
using SpecFlowBdd.TestData.WatchListEntry;
using TechTalk.SpecFlow;

namespace SpecFlowBdd.Steps
{
    [Binding]
    public sealed class StandardMatchingSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public StandardMatchingSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given]
        public void Given_a_product_is_added_with_manufacturer_PRODUCTMANUFACTURER_and_model_PRODUCTMODEL(
            string productManufacturer, string productModel)
        {
            var pages = (Pages)_scenarioContext["pages"];
            var product = new Product()
            {
                Manufacturer = productManufacturer,
                Model = productModel,
                NumberInStock = 1,
                Price = 1,
            };

            pages.NavbarPage.GoToProductList();
            pages.ProductListPage.AddNewProduct();
            pages.ProductAddPage.AddProduct(product);

            _scenarioContext.Add("product", product);
        }

        [Given]
        public void Given_an_entry_is_added_with_manufacturer_ENTRYMANUFACTURER_and_model_ENTRYMODEL(
            string entryManufacturer, string entryModel)
        {
            var pages = (Pages)_scenarioContext["pages"];
            var entry = new WatchListEntry
            {
                Manufacturer = entryManufacturer,
                Model = entryModel,
            };

            pages.NavbarPage.GoToWatchList();
            pages.WatchListPage.AddNewEntry();
            pages.WatchListAddPage.AddEntry(entry);

            _scenarioContext.Add("entry", entry);
        }

        [When]
        public void When_standard_matching_is_enabled()
        {
            var pages = (Pages)_scenarioContext["pages"];

            pages.NavbarPage.GoToProductList();
            pages.ProductListPage.EnableStandardMatching();
        }

        [Then]
        public void Then_the_product_with_manufacturer_PRODUCTMANUFACTURER_and_model_PRODUCTMODEL_is_not_a_match(
            string productManufacturer, string productModel)
        {
            var pages = (Pages)_scenarioContext["pages"];
            var product = (Product)_scenarioContext["product"];

            pages.ProductListPage.VerifyProductIsNotAMatch(product);
        }

        [Then]
        public void Then_the_product_with_manufacturer_PRODUCTMANUFACTURER_and_model_PRODUCTMODEL_is_a_standard_match(
            string productManufacturer, string productModel)
        {
            var pages = (Pages)_scenarioContext["pages"];
            var product = (Product)_scenarioContext["product"];

            pages.ProductListPage.VerifyProductIsAMatch(product);
        }

    }
}
