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
    }
}
