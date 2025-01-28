using Assignment.Models;

namespace Assignment.Services.Interface
{
    public interface IDepartmentService
    {
        Task<bool> AddDepartment(DepartmentVM department);
        Task<IEnumerable<Department>> getalldepartment(); 
        Task<Department> getbyId(int id);
    }
}
