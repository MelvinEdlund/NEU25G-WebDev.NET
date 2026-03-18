namespace DemoWebApi_DI.Data.Entities;

public class User
{
    public User(int userID, string userName, string password)
    {
        UserID = userID;
        UserName = userName;
        Password = password;
    }

    public int UserID { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}
