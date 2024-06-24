using System.ComponentModel.DataAnnotations;

namespace HrApplication.Models
{
    public class EmployeeVM
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Employee Department")]
        public string Department { get; set; }

        [Required]
        public string JobTitle { get; set; }
    }
}
