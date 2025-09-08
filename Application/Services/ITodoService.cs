using System.Data;
using Application.Abstraction;
using Dapper;
using Domain.Entities;

namespace Application.Services;

public interface ITodoService
{
    List<Todo> GetTodos();
    Todo GetTodoById(int id);
    bool Add(Todo todo);
    bool Update(Todo todo);
    bool Delete(int id);
}

public class TodoService : ITodoService
{
    private readonly IDbContext _context;
    public TodoService(IDbContext  context)
    {
        _context = context;
    }
    public List<Todo> GetTodos()
    {
        using var conn = _context.GetConnection();
        string sql = "SELECT * FROM Todo";
        return conn.Query<Todo>(sql).ToList();
        
    }

    public Todo GetTodoById(int id)
    {
        using var conn = _context.GetConnection();
        string sql = "SELECT * FROM Todo WHERE Id = @Id";
        return conn.QueryFirstOrDefault<Todo>(sql, new { Id = id });
    }

    public bool Add(Todo todo)
    {
        using var conn = _context.GetConnection();
        string sql = "INSERT INTO Todo (Title, IsCompleted) VALUES (@Title, @IsCompleted)";
        int rows = conn.Execute(sql, todo);
        return rows > 0;
    }

    public bool Update(Todo todo)
    {
        using var conn = _context.GetConnection();
        string sql = "UPDATE Todo SET Title = @Title, IsCompleted = @IsCompleted WHERE Id = @Id";
        int rows = conn.Execute(sql, todo);
        return rows > 0;
    }

    public bool Delete(int id)
    {
        using var conn = _context.GetConnection();
        string sql = "DELETE FROM Todo WHERE Id = @Id";
        int rows = conn.Execute(sql, new { Id = id });
        return rows > 0;
    }
}