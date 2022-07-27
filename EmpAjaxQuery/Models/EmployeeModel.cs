using System.ComponentModel.DataAnnotations;

namespace EmpAjaxQuery.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Emp_id { get; set; }
        public string Emp_name { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public string Notes { get; set; }
    }
}
