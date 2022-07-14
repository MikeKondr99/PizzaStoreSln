using Microsoft.EntityFrameworkCore;

namespace PizzaStore.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(File.ReadAllText("db.txt"));
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Caterories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
