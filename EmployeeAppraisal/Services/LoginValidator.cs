using EmployeeAppraisal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAppraisal.Services
{
    public interface LoginValidator
    {
        public Employee Validate(string username,string password);
    }
}
