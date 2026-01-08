using _2dars.Services;
using _2dars.Models;
namespace _2dars;

internal class Homework
{
    static List<Car> cars = new List<Car>();
    static List<School> schools = new List<School>();
    static void Main(string[] args)
    {
        CarSeed();
        SchoolSeed();
    }

    static void CarSeed()
    {
        cars.Add(new Car()
        {
            CarId = Guid.NewGuid(),
            Model = "Toyota Camry",
            Year = 2020,
            Price = 24000m,
            Description = "A reliable and fuel-efficient sedan.",
            Created = DateTime.Now,
            Color = "Blue"
        });
        cars.Add(new Car()
        {
            CarId = Guid.NewGuid(),
            Model = "Ford Mustang",
            Year = 2019,
            Price = 26000m,
            Description = "A classic American muscle car with modern features.",
            Created = DateTime.Now,
            Color = "Red"
        });
    }

    static void SchoolSeed()
    {
        schools.Add(new School()
        {
            SchoolId = Guid.NewGuid(),
            Name = "Greenwood High",
            Address = "123 Main St, Springfield",
            EstablishedUtc = new DateTime(1995, 8, 15),
            StudentCount = 850,
            Principal = "Dr. Emily Carter"
        });
        schools.Add(new School()
        {
            SchoolId = Guid.NewGuid(),
            Name = "Lakeside Academy",
            Address = "456 Lakeview Dr, Springfield",
            EstablishedUtc = new DateTime(2000, 9, 1),
            StudentCount = 1200,
            Principal = "Mr. John Smith"
        });
    }
}
