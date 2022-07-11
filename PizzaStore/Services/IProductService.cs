using PizzaStore.Models;

namespace PizzaStore.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>?> GetProductsAsync();
    }
}