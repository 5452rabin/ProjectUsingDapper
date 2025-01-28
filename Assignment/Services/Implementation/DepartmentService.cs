using Assignment.DataAccess;
using Assignment.Models;
using Assignment.Services.Interface;
using NuGet.Versioning;

namespace Assignment.Services.Implementation
{
    public class DepartmentService : IDepartmentService
    {
        private readonly ISQLDataAccess _dataaccess;
        public DepartmentService(ISQLDataAccess dataaccess)
        {
            _dataaccess = dataaccess;
        }
        public async Task<bool> AddDepartment(DepartmentVM department)
        {
            try
            {
                if (department.Id==0)
                {
                    await _dataaccess.SaveData("sp_create_department", new { departmentName=department.Name });
                }else
                {
                    await _dataaccess.SaveData("sp_update_department", new { id=department.Id, departmentName=department.Name });
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Department>> getalldepartment()
        {
            
                return await _dataaccess.GetData<Department, dynamic>("sp_getall_department", new { });
        }

        public async Task<Department> getbyId(int id)
        {
            IEnumerable<Department> departments =await  getalldepartment();
            return departments.FirstOrDefault(x => x.Id == id);
        }
    }
}
