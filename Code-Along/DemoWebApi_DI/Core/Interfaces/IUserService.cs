using DemoWebApi_DI.Data.Entities;

namespace DemoWebApi_DI.Core.Interfaces;


// Detta är ett kontrakt som servicen följa. Gör att vi sedan kan sätta upp
// det med DI och få en lösare koppling
public interface IUserService
{
    List<User> GetAllUsers();

    bool Login(User user);

    User Register(User user);
    bool Delete(int userId);


}
