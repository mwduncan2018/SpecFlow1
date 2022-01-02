using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;

namespace SpecFlowBdd.TestData.Product
{
    public class ProductProvider
    {
        public ProductProvider() { }

        public List<Product> GetAllProducts()
        {
            return JsonSerializer.Deserialize<List<Product>>(File.ReadAllText(GetProductTestDataDirectory()));            
        }

        public Product GetProduct(string id)
        {
            return GetAllProducts()
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }

        public Product GetProduct(string manufacturer, string model)
        {
            return GetAllProducts()
                .Where(x => x.Manufacturer == manufacturer)
                .Where(y => y.Model == model)
                .FirstOrDefault();
        }

        public string PrintJsonForProduct(Product product)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize<Product>(product, options);
            Console.WriteLine(json);
            return json;
        }
        
        public string PrintJsonForProductList(IEnumerable<Product> collection)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize<IEnumerable<Product>>(collection, options);
            Console.WriteLine(json);
            return json;
        }

        private string GetProductTestDataDirectory()
        {
            var w = AppDomain.CurrentDomain.BaseDirectory;
            w = (Directory.GetParent(w)).FullName;
            w = (Directory.GetParent(w)).FullName;
            w = (Directory.GetParent(w)).FullName;
            w = (Directory.GetParent(w)).FullName;
            w = (Directory.GetParent(w)).FullName;
            w = (Directory.GetParent(w)).FullName;
            w = w + "\\TestData\\Product\\product-test-data.json";
            return w;
        }
    }
}
