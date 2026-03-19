using DemoFullstack1_backend.Data.Entities;
using DemoFullstack1_backend.Data.Interfaces;

namespace DemoFullstack1_backend.Data.Repos;

public class TodoRepo: ITodoRepo
{
    public List<Todo> SearchTodo(string condition)
    {
        // Detta görs i vanliga fall mot en databas
        var list = new List<Todo>()
        {
            new Todo(1, 1, "Plugga", true),
            new Todo(1, 2, "Träna", true),
            new Todo(1, 3, "Städa", true),
            new Todo(1, 4, "Handla", true),
            new Todo(1, 5, "Hacka", true),
            new Todo(1, 6, "Söka", true)
        };

        return list.Where(t => t.Title.Contains(condition)).ToList();

    }


}
