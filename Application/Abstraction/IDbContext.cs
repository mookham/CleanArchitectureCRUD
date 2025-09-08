using System.Data;

namespace Application.Abstraction;

public interface IDbContext
{
    IDbConnection GetConnection();
    
}