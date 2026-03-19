namespace DemoFullstack1_backend.Data.Entities;

public class Todo
{
    public Todo(int userId, int id, string title, bool completed)
    {
        this.userId = userId;
        Id = id;
        Title = title;
        Completed = completed;
    }

    public int userId { get; set; }
    public int Id { get; set; }
    public string Title { get; set; }
    public bool Completed { get; set; }

}
