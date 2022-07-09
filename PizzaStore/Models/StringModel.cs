namespace PizzaStore.Models
{
    public class StringModel
    {
        public string Text { get; set; }

        public StringModel(string text)
        {
            this.Text = text;
        }
    }


    class Pizza
    {
        public string Name { get; set; }

        public Pizza(string name)
        {
            Name = name;
        }
    }
}
