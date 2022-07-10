namespace PizzaStore.Models
{
    public class Product
    {
        public Product(string name,double price, string description="", string imageSourse="", uint discount=0, bool outOfStoke=false)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            ImageSourse = imageSourse ?? throw new ArgumentNullException(nameof(imageSourse));
            Price = price;
            Discount = discount;
            OutOfStoke = outOfStoke;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageSourse { get; set; }
        public double Price { get; set; }
        public uint Discount { get; set; }
        public bool OutOfStoke { get; set; }
    }
}
