using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    public class Department
    {
        [Column("DepartmentId")]
        public int Id { get; set; }

        [Column("DepartmentName")]
        public string Name { get; set; }
    
    }
}
