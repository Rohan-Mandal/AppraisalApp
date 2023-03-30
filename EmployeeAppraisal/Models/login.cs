using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace EmployeeAppraisal.Models
{
    public class login
    {
        [Required(ErrorMessage = "Please Enter The Email Address")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Required(ErrorMessage = "Please Enter The Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
