using DemoFullstack1_backend.Data.Entities;

namespace DemoFullstack1_backend.Core.Interfaces;

public interface ITodoService
{
    List<Todo> SearchTodo(string condition);
}
