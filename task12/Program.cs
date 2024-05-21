using task12;

public static class Program
{
    public static void Main()
    {
        Product product1 = new Product("Milk", 3, task12.Type.Groceries);
        Product product2 = new Product("Beko", 2000, task12.Type.Electronics);
        Product product3 = new Product("Jacket", 120, task12.Type.Clothes);
        Product product4 = new Product("Macbook", 4000, task12.Type.Electronics);
        ProductCatalog catalog = new ProductCatalog();
        catalog.AddProduct(product1);
        catalog.AddProduct(product2);
        catalog.GetAllProductsByType(task12.Type.Electronics);
        catalog.GetAllProducts();
    }
}