using DemoFullstack1_backend.Data.Entities;

namespace DemoFullstack1_backend.Data.Interfaces;

public interface ITodoRepo
{
    List<Todo> SearchTodo(string condition);

}
