using System;
using System.ComponentModel.DataAnnotations;

namespace EmpAjaxQuery.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Emp_id { get; set; }
        public string Emp_name { get; set; }
        public string Profile_img { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        [Range(0, 500000)]
        public double Salary { get; set; }
        public DateTime StartDate { get; set; }
        public string Notes { get; set; }
    }
}
