namespace _5dars.Models;

public class Country
{
    public Guid CountryId { get; set; }
    public int Id { get; set; } 
    public string Name { get; set; } 
    public string Capital { get; set; }
    public long Population { get; set; }
}
