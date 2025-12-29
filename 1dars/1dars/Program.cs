namespace _1dars;

internal class Program
{
    static void Main(string[] args)
    {
        Product product = new Product()
        {
            GuidOfProduct = Guid.NewGuid(),
            ProductName = "Laptop",
            Price = 1500,
            date = DateTime.Now,
            Description = "A high-performance laptop suitable for gaming and professional work."

        };
        Console.WriteLine(product);
    } 
}

