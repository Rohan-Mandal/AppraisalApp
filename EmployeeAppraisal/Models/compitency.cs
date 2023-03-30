using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAppraisal.Models
{
    public class compitency
    {
        [Key]
        public int Id { get; set; }


        [Required]

        public int AID { get; set; }

        [Required]

        public int compi { get; set; }

    }
}
