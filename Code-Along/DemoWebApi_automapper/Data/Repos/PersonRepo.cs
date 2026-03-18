using DemoWebApi_automapper.Data.Entities;
using DemoWebApi_automapper.Data.Interfaces;

namespace DemoWebApi_automapper.Data.Repos;

public class PersonRepo : IPersonRepo
{
    public Person GetPerson(int id)
    {
        // Detta kommer i vanliga fall från databasen och mappas till Person klassen med EF
        var person = new Person(1, "Sebbe Breuker", "sebbebreuker@gmail.com", "0732338296");
        return person;
    }
}
