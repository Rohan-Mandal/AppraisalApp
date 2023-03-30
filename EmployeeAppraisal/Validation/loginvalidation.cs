using EmployeeAppraisal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAppraisal.Models;

namespace EmployeeAppraisal.Validation
{
    public class loginvalidation
    {
        private readonly EmployeeContext _employeeContext;
        

        public loginvalidation(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

       

        //this method will verify the id and the password

        public Employee Validate(string username, string password)
        {


         


            var status = _employeeContext.Employee.Where(m => m.Email == username && m.Password == password).FirstOrDefault();


            return status;

        }


    }
}

