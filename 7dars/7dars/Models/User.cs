namespace _7dars.Models;

public class User
{
	private Guid userID;
	public Guid userId
	{
		get { return userID; }
		set { userID = value; }
	}

	private string Username;
	public string UserName
	{
		get { return Username; }
		set { Username = value; }
	}

	private string FirstName;
	public string firstName
	{
		get { return FirstName; }
		set { FirstName = value; }
    }

	private string LastName;
	public string lastName
	{
		get { return LastName; }
		set { LastName = value; }
    }

    private string Password;
	public string password
	{
		get { return Password; }
		set { Password = value; }
    }

	private string Email;
	public string email
	{
		get { return Email; }
		set { Email = value; }
    }

	private string PhoneNumber;
	public string phoneNumber
	{
		get { return PhoneNumber; }
		set { PhoneNumber = value; }
    }
}
