using System.Data;
using Dapper;

namespace DapperDemoCSharp_49;

public class DepartmentRepo : IDepartmentRepo
{
    private readonly IDbConnection _connection;

    public DepartmentRepo(IDbConnection connection)
    {
        _connection = connection;
    }
    
    public IEnumerable<Department> GetAllDepartments()
    {
        return _connection.Query<Department>("SELECT * FROM departments;");
    }

    public void InsertDepartment(string newDepartmentName)
    {
        _connection.Execute("INSERT INTO departments (Name) VALUES (@newDepartmentName)", new { newDepartmentName });
    }
}