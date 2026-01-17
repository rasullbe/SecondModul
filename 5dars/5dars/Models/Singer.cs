namespace _5dars.Models;

public class Singer
{
    public Guid SingerId { get; set; }
    public string Name { get; set; }
    public string Genre { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
}
