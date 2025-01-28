using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class DepartmentVM
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "The Department Name field is required.")]
        public string Name { get; set; }
        public IEnumerable<Department> Departments { get; set; }
    }
}
