using _2dars.Models;
namespace _2dars.Services;

internal class CarService
{

    public List<Car> cars = new List<Car>();
    public Guid AddCar(Car car)
    {
        car.CarId = Guid.NewGuid();
        car.Created = DateTime.UtcNow;
        cars.Add(car);
        return car.CarId;
    }

    public Guid DeleteCar(Guid carId)
    {
        Car car = null;

        foreach (var c in cars)
        {
            if (c.CarId == carId)
            {
                car = c;
                break;
            }
        }

        if (car != null)
        {
            cars.Remove(car);
            return carId;
        }
        return Guid.Empty;
    }

    public List<Car> GetAllCars()
    {
        return cars;
    }

    public void UpdateCar(Car updatedCar)
    {
        Car existinBook = null;

        foreach (var c in cars)
        {
            if (c.CarId == updatedCar.CarId)
            {
                existinBook = c;
                break;
            }
        }

        if (existinBook != null)
        {
            existinBook.Model = updatedCar.Model;
            existinBook.Year = updatedCar.Year;
            existinBook.Price = updatedCar.Price;
            existinBook.Description = updatedCar.Description;
            existinBook.Color = updatedCar.Color;
        }
    }
}
