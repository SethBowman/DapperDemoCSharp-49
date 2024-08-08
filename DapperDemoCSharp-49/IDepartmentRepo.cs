namespace DapperDemoCSharp_49;

public interface IDepartmentRepo
{
    public IEnumerable<Department> GetAllDepartments();
    public void InsertDepartment(string newDepartmentName);
}