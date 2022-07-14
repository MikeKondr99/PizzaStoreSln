using System.ComponentModel.DataAnnotations;

namespace PizzaStore.Database
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public Product Product { get; set; }
        public uint Count { get; set; }
    }
}
