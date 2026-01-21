namespace _7dars.Services;

public interface IUserService
{
    public string GetUserName(int userId);
    public string GetPassword(int userId);
    public string GetEmail(int userId);
    public string GetPhoneNumber(int userId);
    
}