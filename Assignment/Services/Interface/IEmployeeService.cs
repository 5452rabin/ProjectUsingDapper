using Assignment.Models;

namespace Assignment.Services.Interface
{
    public interface IEmployeeService
    {
        Task<bool> AddEmployee(AddEmployeeVM addEmployeeVM);
        Task<IEnumerable<AddEmployeeVM>> GetAll();
        Task<AddEmployeeVM> GetEmployeebyId(int id);
        Task<bool> DeleteEmployee(int id);
        Task<IEnumerable<AddEmployeeVM>> GetEmployeeBydepartmentid(int id);
    }
}
