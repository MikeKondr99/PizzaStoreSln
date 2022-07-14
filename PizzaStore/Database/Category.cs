using System.ComponentModel.DataAnnotations;

namespace PizzaStore.Database
{
    public class Category
    {
        [Key]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
