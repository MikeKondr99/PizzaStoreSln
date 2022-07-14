using System.ComponentModel.DataAnnotations;

namespace PizzaStore.Database
{
    public class Product
    {
   
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageSource { get; set; }
        public double Price { get; set; }
        public uint Discount { get; set; }
        public uint InStock { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
