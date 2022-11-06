namespace CS30_Linq
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string[] Colors { get; set; }
        public int Brand { get; set; }
        public Product(int id, string name, double price, string[] colors, int brand)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Colors = colors;
            this.Brand = brand;
        }
        public override string ToString() => $"{ID,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors)}";
    }
}