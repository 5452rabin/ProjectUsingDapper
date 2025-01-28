

using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class AddEmployeeVM
    {

        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Name field is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Salary is required.")]
        [Range(0.01, 99999999999999.99, ErrorMessage = "Salary must be between 0.01 and 99999999999999.99.")]
        public decimal Salary {  get; set; }
        public string Department { get; set; }
        public IEnumerable<Department> Departments { get; set; }
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Date of Joining is required.")]
        [DataType(DataType.Date)]
        public DateTime DateofJoining { get; set; }=DateTime.Now;
    }
}
