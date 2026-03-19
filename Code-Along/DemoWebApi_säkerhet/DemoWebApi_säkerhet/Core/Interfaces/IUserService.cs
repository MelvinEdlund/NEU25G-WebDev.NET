using DemoWebApi_säkerhet.Data.Entities;

namespace DemoWebApi_säkerhet.Core.Interfaces
{
    public interface IUserService
    {
        bool Login(User user);

        string GenerateToken(User user);
    }
}
