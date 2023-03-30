using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAppraisal.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public int EID { get; set; }
        [Required(ErrorMessage ="Enter Valid Name")]
        [DisplayName("Employee Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Choose Valid Designation")]
        [DisplayName("Employee Designation")]
        public string Designation { get; set; }
        [Required(ErrorMessage = "Enter Valid Email")]
        [DisplayName("Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Strong Password")]
        [DisplayName("Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Choose Valid MID")]
        [DisplayName("Manager ID")]
        public int MID { get; set; }

    }
}
