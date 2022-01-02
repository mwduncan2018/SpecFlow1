using SpecFlowBdd.PageModels;
using SpecFlowBdd.TestData.Product;
using TechTalk.SpecFlow;

namespace SpecFlowBdd.Steps
{
    [Binding]
    public sealed class FuzzyMatchingSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public FuzzyMatchingSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When]
        public void When_fuzzy_matching_is_enabled()
        {
            var pages = (Pages)_scenarioContext["pages"];

            pages.NavbarPage.GoToProductList();
            pages.ProductListPage.EnableFuzzyMatching();
        }

        [Then]
        public void Then_the_product_with_manufacturer_PRODUCTMANUFACTURER_and_model_PRODUCTMODEL_is_a_fuzzy_match(
            string productManufacturer, string productModel)
        {
            var pages = (Pages)_scenarioContext["pages"];
            var product = (Product)_scenarioContext["product"];

            pages.ProductListPage.VerifyProductIsAFuzzyMatch(product);
        }


    }
}
