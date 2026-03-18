namespace DemoWebApi_automapper.Data.DTO;


// Detta är en DTO klass = data transfer object. Det är det format som webapi:et använder EXTERNT
// och skickar ner till klienten
public class PersonDTO
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Mail { get; set; }

}
