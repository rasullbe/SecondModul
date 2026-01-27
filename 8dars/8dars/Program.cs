using _8dars.Services;

namespace _8dars;

internal class Program
{
    static void Main(string[] args)
    {
        INotificationService notificationService = GetNotification();
        notificationService.SendNotification();

    }

    public static INotificationService GetNotification()
    {
        INotificationService notice = new EmailNotificationService();
        return notice;
    }
}
