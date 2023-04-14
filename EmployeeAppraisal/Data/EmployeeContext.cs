using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAppraisal.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAppraisal.Data
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options): base(options)
        {
                
        }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<createappraisal> createappraisals { get; set; }


        public DbSet<compitency> compitencies { get; set; }

        public DbSet<Appraisal> Appraisal { get; set; }
    }
}
