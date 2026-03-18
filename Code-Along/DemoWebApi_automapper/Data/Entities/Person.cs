namespace DemoWebApi_automapper.Data.Entities;

// Denna klass mappar en tabell i databasen och hanteras av EF
// (en ORM = object relational mapper) dvs mappa data från en
// relationsdatabas med entitetsklasser. Detta format används
// INTERNT i web api:et
public class Person
{

    public int PersonID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public Person(int personID, string name, string email, string phone)
    {
        PersonID = personID;
        Name = name;
        Email = email;
        Phone = phone;
    }

}
