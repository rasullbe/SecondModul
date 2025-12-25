namespace _1dars;

public class Product
{
    public Guid GuidOfProduct { get; set; }
    public string ProductName { get; set; }
    public int Price { get; set; }
    public DateTime date { get; set; }
    public string Description { get; set; }



    override public string ToString()
    {
        return $"Guid: {GuidOfProduct}\nName: {ProductName}\nPrice: {Price}\nDate: {date}\nDescription: {Description}\n";
    }
}
