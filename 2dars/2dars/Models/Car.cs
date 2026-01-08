namespace _2dars.Models;

public class Car
{
    public Guid CarId { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public DateTime Created { get; set; }
    public string Color { get; set; }
}
