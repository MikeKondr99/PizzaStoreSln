using PizzaStore.Models;
using System.Text.Json;

namespace PizzaStore.Services
{
    public class ProductListService : IProductService
    {
        public ProductListService()
        {
            products = JsonSerializer.Deserialize<List<Product>>(
                new FileStream("products.json", FileMode.Open)
                ) 
                ?? new List<Product>();
        }

        List<Product> products;
        public async Task<IEnumerable<Product>?> GetProductsAsync()
        {
            return products;
        }
    }



}
