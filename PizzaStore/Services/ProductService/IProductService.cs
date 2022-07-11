using PizzaStore.Database;

namespace PizzaStore.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>?> GetProductsAsync();
    }
}