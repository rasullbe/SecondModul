using _7dars.Models;

namespace _7dars;

internal class Program
{
    static void Main(string[] args)
    {
        User user = new User()
        {
            userId = Guid.NewGuid(),
            UserName = "john_doe",
            firstName = "John",
            lastName = "Doe",
            password = "securepassword123",
            email = "johndoeisagoodguy@gmail.com",
            phoneNumber = "+1234567890"
        };


        Console.WriteLine($"User Created: {user.UserName}, Email: {user.email}");
    }
}