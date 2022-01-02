using SpecFlowBdd.PageModels;
using SpecFlowBdd.TestData.Product;
using TechTalk.SpecFlow;

namespace SpecFlowBdd.Steps
{
    [Binding]
    public sealed class ProductListSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public ProductListSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When]
        public void When_products_are_viewed()
        {
            ((Pages)_scenarioContext["pages"]).NavbarPage.GoToProductList();
        }

        [Then]
        public void Then_a_product_can_be_created()
        {
            var pages = (Pages)_scenarioContext["pages"];
            var product = new ProductProvider().GetProduct("1");

            pages.NavbarPage.GoToProductList();
            pages.ProductListPage.AddNewProduct();
            pages.ProductAddPage.AddProduct(product);

            _scenarioContext["product"] = product;
        }

        [Then]
        public void Then_a_product_can_be_edited()
        {
            var pages = (Pages)_scenarioContext["pages"];
            var product = (Product)_scenarioContext["product"];

            pages.NavbarPage.GoToProductList();
            pages.ProductListPage.Edit(product);
            product.Manufacturer += " Testing";
            product.Model += " Testing";
            product.Price += 1;
            product.NumberInStock += 1;
            pages.ProductEditPage.Edit(product);
            pages.ProductListPage.VerifyProductIsDisplayed(product);
        }

        [Then]
        public void Then_a_product_can_be_read()
        {
            var pages = (Pages)_scenarioContext["pages"];
            var product = (Product)_scenarioContext["product"];

            pages.NavbarPage.GoToProductList();
            pages.ProductListPage.Details(product);
            pages.ProductDetailsPage.VerifyDetailsAreDisplayedFor(product);
        }

        [Then]
        public void Then_a_product_can_be_deleted()
        {
            var pages = (Pages)_scenarioContext["pages"];
            var product = (Product)_scenarioContext["product"];

            pages.NavbarPage.GoToProductList();
            pages.ProductListPage.Delete(product);
            pages.ProductDeletePage.ConfirmDelete();
            pages.ProductListPage.VerifyProductIsNotDisplayed(product);
        }
    }
}