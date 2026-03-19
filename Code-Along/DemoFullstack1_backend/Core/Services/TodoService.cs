using DemoFullstack1_backend.Core.Interfaces;
using DemoFullstack1_backend.Data.Entities;
using DemoFullstack1_backend.Data.Interfaces;
using DemoFullstack1_backend.Data.Repos;

namespace DemoFullstack1_backend.Core.Services;

public class TodoService: ITodoService
{
    private readonly ITodoRepo _repo;

    public TodoService(ITodoRepo repo)
    {
        _repo = repo;
    }

    public List<Todo> SearchTodo(string condition)
    {
        return _repo.SearchTodo(condition);
    }
}
