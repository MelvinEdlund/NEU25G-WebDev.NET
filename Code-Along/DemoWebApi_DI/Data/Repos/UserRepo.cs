using DemoWebApi_DI.Data.Entities;
using DemoWebApi_DI.Data.Interfaces;

namespace DemoWebApi_DI.Data.Repos;

public class UserRepo : IUserRepo
{
    private readonly List<User> _users;
    public UserRepo()
    {
        _users = new List<User>
        {
            new User(1, "Lisa", "password1"),
            new User(2, "Lars", "password2"),
            new User(3, "Kalle", "password3")


        };

    }
    public List<User> GetAllUsers()
    {
        return _users;
    }


    public bool Login(User user)
    {

        return _users.Any(u =>
        u.UserName.Equals(user.UserName, StringComparison.OrdinalIgnoreCase) &&
        u.Password == user.Password);
    }

    public User Register (User user)
    {
        if (string.IsNullOrWhiteSpace(user.UserName))
            throw new ArgumentException("Username får inte vara tomt.");

        if (string.IsNullOrWhiteSpace(user.Password))
            throw new ArgumentException("Password får inte vara tomt.");

        bool userNameTaken = _users.Any(u =>
            u.UserName.Equals(user.UserName, StringComparison.OrdinalIgnoreCase));

        if (userNameTaken)
            throw new InvalidOperationException("UserName är redan taget.");

        int nextId = _users.Count == 0 ? 1 : _users.Max(u => u.UserID) + 1;

        var created = new User(nextId, user.UserName, user.Password);
        _users.Add(created);

        return created;
    }
    public bool Delete(int userId)
    {
        var user = _users.FirstOrDefault(u => u.UserID == userId);
        if (user is null)
            return false;

        _users.Remove(user);
        return true;
    }

}
