using DemoWebApi_automapper.Data.DTO;
using DemoWebApi_automapper.Data.Entities;

namespace DemoWebApi_automapper.Data.Interfaces;

public interface IPersonRepo
{
    Person GetPerson(int id);

}
