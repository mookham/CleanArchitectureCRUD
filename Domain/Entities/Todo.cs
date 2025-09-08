namespace Domain.Entities;

public class Todo
{
    public String Id { get; set; } = Guid.NewGuid().ToString();
    public String Title { get; set; }
    public bool IsCompleted { get; set; }
}