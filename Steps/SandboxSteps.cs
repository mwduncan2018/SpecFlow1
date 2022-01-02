using System;
using System.Linq;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using SpecFlowBdd.TestData.Product;
using SpecFlowBdd.TestData.WatchListEntry;

namespace SpecFlowBdd.Steps
{
    [Binding]
    [Scope(Feature = "Sandbox")]
    public sealed class SandboxSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public SandboxSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given]
        public void Given_sandbox_code()
        {
            foreach (var x in new ProductProvider().GetAllProducts())
                Console.WriteLine(
                    x.Id + " = " + 
                    x.Manufacturer + " " + 
                    x.Model + "... " + 
                    x.Price + "... " + 
                    x.NumberInStock);
            foreach (var y in new WatchListEntryProvider().GetAllEntries())
                Console.WriteLine(
                    y.Id + " = " + 
                    y.Manufacturer + " " 
                    + y.Model);
        }

        [Given]
        public void Given_product_test_data_is_created()
        {
            var a = new Product
            {
                Id = "1",
                Manufacturer = "T. Rowe Price",
                Model = "Dividend Growth Fund",
                Price = 1,
                NumberInStock = 1,
            };
            var b = new Product
            {
                Id = "2",
                Manufacturer = "T. Rowe Price",
                Model = "Blue Chip Growth Fund",
                Price = 1,
                NumberInStock = 1,
            };
            var c = new Product
            {
                Id = "3",
                Manufacturer = "T. Rowe Price",
                Model = "Global Growth Sock Fund",
                Price = 1,
                NumberInStock = 1,
            };
            var d = new Product
            {
                Id = "4",
                Manufacturer = "T. Rowe Price",
                Model = "Communications & Technology Fund",
                Price = 1,
                NumberInStock = 1,
            };
            var e = new Product
            {
                Id = "5",
                Manufacturer = "T. Rowe Price",
                Model = "Large-Cap Growth Fund",
                Price = 1,
                NumberInStock = 1,
            };
            var f = new Product
            {
                Id = "6",
                Manufacturer = "Vanguard",
                Model = "Dividend Growth",
                Price = 1,
                NumberInStock = 1,
            };
            var g = new Product
            {
                Id = "7",
                Manufacturer = "Vanguard",
                Model = "500 Index Admiral Shares",
                Price = 1,
                NumberInStock = 1,
            };
            var h = new Product
            {
                Id = "8",
                Manufacturer = "Vanguard",
                Model = "Windsor",
                Price = 1,
                NumberInStock = 1,
            };
            var i = new Product
            {
                Id = "9",
                Manufacturer = "Vanguard",
                Model = "Explorer Value",
                Price = 1,
                NumberInStock = 1,
            };
            var productList = new List<Product>();
            productList.Add(a);
            productList.Add(b);
            productList.Add(d);
            productList.Add(e);
            productList.Add(f);
            productList.Add(g);
            productList.Add(h);
            productList.Add(i);

            new ProductProvider().PrintJsonForProductList(productList);
        }

        [Given]
        public void Given_watch_list_test_data_is_created()
        {
            var a = new WatchListEntry
            {
                Id = "1",
                Manufacturer = "T. Rowe Price",
                Model = "Dividend Growth Fund",
            };
            var b = new WatchListEntry
            {
                Id = "2",
                Manufacturer = "T. Rowe Price",
                Model = "Blue Chip Growth Fund",
            };
            var c = new WatchListEntry
            {
                Id = "3",
                Manufacturer = "Vanguard",
                Model = "Stategic Small-Cap Equity",
            };
            var d = new WatchListEntry
            {
                Id = "4",
                Manufacturer = "Vanguard",
                Model = "Selected Value",
            };
            var e = new WatchListEntry
            {
                Id = "5",
                Manufacturer = "Vanguard",
                Model = "Global Credit Bond",
            };
            var f = new WatchListEntry
            {
                Id = "6",
                Manufacturer = "Vanguard",
                Model = "Dividend Growth",
            };
            var g = new WatchListEntry
            {
                Id = "7",
                Manufacturer = "Vanguard",
                Model = "500 Index Admiral Shares",
            };
            var entries = new List<WatchListEntry>();
            entries.Add(a);
            entries.Add(b);
            entries.Add(c);
            entries.Add(d);
            entries.Add(e);
            entries.Add(f);
            entries.Add(g);

            new WatchListEntryProvider().PrintJsonForWatchList(entries);
        }
    }
}