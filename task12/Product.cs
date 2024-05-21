namespace task12
{
    internal class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Type Type { get; set; }
        public Product(string name, int price, Type type)
        {
            Name = name;
            Price = price;
            Type = type;
        }
        public void GetDetails(Product product)
        {
            Console.WriteLine($"{product.Name} {product.Price} {product.Type}");
        }
    }
    public enum Type
    {
        Electronics,
        Clothes,
        Books,
        Groceries
    }
}
