using DemoWebApi_DI.Data.Entities;

namespace DemoWebApi_DI.Data.Interfaces;

public interface IUserRepo
{

    List<User> GetAllUsers();

    bool Login(User user);

    User Register(User user);
    bool Delete(int userId);
}
