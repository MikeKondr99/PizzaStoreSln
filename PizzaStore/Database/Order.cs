using System.ComponentModel.DataAnnotations;

namespace PizzaStore.Database
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool Completed { get; set; }
        public ICollection<OrderItem> Products { get; set; }

    }
}
