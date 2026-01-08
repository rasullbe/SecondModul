namespace _2dars.Models;

internal class School
{
    public Guid SchoolId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public DateTime EstablishedUtc { get; set; }
    public int StudentCount { get; set; }
    public string Principal { get; set; }
}
