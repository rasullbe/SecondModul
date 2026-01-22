using _8dars.Models;
namespace _8dars.Services;

public class EmailService : INotificationService
{
    public void SendNotification()
    {
        Console.WriteLine("Всем привет");
    }
}
