using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAppraisal.Models
{
    public class Status
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ForeignKey("AppraisalForm")]
        public int AppID { get; set; }

        [Required]
        public int Competency { get; set; }
    }
}
