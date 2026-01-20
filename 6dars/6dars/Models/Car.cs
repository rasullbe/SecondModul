namespace _6dars.Models;

public class Car
{
    public Guid Guid { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int MaxSpeed { get; set; }
    public string Description { get; set; }
}
