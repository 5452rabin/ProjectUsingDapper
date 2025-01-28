using Assignment.DataAccess;
using Assignment.Models;
using Assignment.Services.Interface;

namespace Assignment.Services.Implementation
{
    public class EmployementService : IEmployeeService
    {
        private readonly ISQLDataAccess _sQLDataAccess;
        private readonly IDepartmentService _DepartmentService;
        public EmployementService(ISQLDataAccess sQLDataAccess, IDepartmentService departmentService)
        {
            _sQLDataAccess = sQLDataAccess;
            _DepartmentService = departmentService;
        }
        public async Task<bool> AddEmployee(AddEmployeeVM addEmployeeVM)
        {
            try {
                Department department=await _DepartmentService.getbyId(addEmployeeVM.DepartmentId);

                if (addEmployeeVM.EmployeeId==0)
                {
                    var param = new { 
                        name = addEmployeeVM.Name,
                        salary = addEmployeeVM.Salary,
                        dateOfJoin=addEmployeeVM.DateofJoining,
                        departmentid=addEmployeeVM.DepartmentId,
                        department=department.Name,
                    };
                    await _sQLDataAccess.SaveData("sp_add_employee", param);
                }else
                {
                    var param = new
                    {
                        id = addEmployeeVM.EmployeeId,
                        name = addEmployeeVM.Name,
                        salary = addEmployeeVM.Salary,
                        dateofjoin = addEmployeeVM.DateofJoining,
                        departmentid = addEmployeeVM.DepartmentId,
                        department = department.Name,
                    };

                    await _sQLDataAccess.SaveData("sp_update_employee", param);
                }
                return true;

            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteEmployee(int id)
        {
           
                return await _sQLDataAccess.DeleteData("sp_delete_employee", new {id=id});
          
        }

        public async Task<IEnumerable<AddEmployeeVM>> GetAll()
        {
            return await _sQLDataAccess.GetData<AddEmployeeVM, dynamic>("sp_getall_employee", new { });
        }

        public async Task<AddEmployeeVM> GetEmployeebyId(int id)
        {
            IEnumerable<AddEmployeeVM> addEmployeeVMs=await GetAll();
            return addEmployeeVMs.FirstOrDefault(x => x.EmployeeId == id);
        }

        public async Task<IEnumerable<AddEmployeeVM>> GetEmployeeBydepartmentid(int id)
        {
            return await _sQLDataAccess.GetData<AddEmployeeVM, dynamic>("sp_getemp_bydepid", new {id=id });

        }
    }
}
