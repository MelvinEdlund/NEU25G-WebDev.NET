using DemoWebApi_DI.Core.Interfaces;
using DemoWebApi_DI.Data.Entities;
using DemoWebApi_DI.Data.Interfaces;
using DemoWebApi_DI.Data.Repos;

namespace DemoWebApi_DI.Core.Services;

public class UserService : IUserService
{
    private readonly IUserRepo _userRepo;
    public UserService(IUserRepo userRepo)
    {
        _userRepo = userRepo;
    }
    public List<User> GetAllUsers()
    {
        return _userRepo.GetAllUsers();
    }

    public bool Login(User user)
    {
        // Här ligger logiken för inloggning
        return _userRepo.Login(user);
    }

    public User Register(User user)
    {
        return _userRepo.Register(user);
    }
    public bool Delete(int userId)
    {
        return _userRepo.Delete(userId);
    }
}
