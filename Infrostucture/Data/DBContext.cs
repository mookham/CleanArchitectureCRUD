using System.Data;
using System.Diagnostics.CodeAnalysis;
using Application.Abstraction;
using Npgsql;

namespace Infrostucture.Data;

public class DBContext : IDbContext
{
    public String _connectionString = "Server=localhost; Port=5432;Database=todo;User Id=postgres; Password=123456";
    public IDbConnection GetConnection()
    {
        return new NpgsqlConnection(_connectionString);
    }
    
}