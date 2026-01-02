namespace _1dars;

internal class Program
{
    static void Main(string[] args)
    {
            CreateProduct("Laptop", 1500, "Gaming laptop");
            CreateProduct("Phone", 800, "Smartphone");

            ReadAllProducts();

            Guid firstProductId = products[0].GuidOfProduct;
            UpdateProductPrice(firstProductId, 1200);

            DeleteProduct(firstProductId);

            ReadAllProducts();
            
    }

    static List<Product> products = new List<Product>();

    static void CreateProduct(string name, int price, string description)
    {
        Product product = new Product()
        {
            GuidOfProduct = Guid.NewGuid(),
            ProductName = name,
            Price = price,
            date = DateTime.Now,
            Description = description
        };
        products.Add(product);
        Console.WriteLine($"Product {name} created!");
    }

    static Product ReadProduct(Guid id)
    {
        return products.FirstOrDefault(p => p.GuidOfProduct == id);
    }

    static void ReadAllProducts()
    {
        foreach (var product in products)
        {
            Console.WriteLine($"ID: {product.GuidOfProduct}, Name: {product.ProductName}, Price: {product.Price}, Description: {product.Description}, Date: {product.date}");
        }
    }

    static void UpdateProductPrice(Guid id, int newPrice)
    {
        var product = ReadProduct(id);
        if (product != null)
        {
            product.Price = newPrice;
            Console.WriteLine($"Price updated to {newPrice}");
        }
    }

    static void DeleteProduct(Guid id)
    {
        var product = ReadProduct(id);
        if (product != null)
        {
            products.Remove(product);
            Console.WriteLine($"Product {product.ProductName} deleted!");
        }
    }
}