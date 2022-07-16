using Microsoft.EntityFrameworkCore;
using PizzaStore.Database;

namespace PizzaStore.Services
{
    public class ProductDBService : IProductService
    {
        private DatabaseContext _databaseContext;

        public ProductDBService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _databaseContext.Database.EnsureCreated();
        }

        public async Task<Product?> GetProduct(int id)
        {
            return await _databaseContext.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>?> GetProductsAsync()
        {
            return await _databaseContext.Products.Include(p => p.Categories).ToListAsync();
        }
    }
}