using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAppraisal.Models
{
    public class createappraisal
    {
        [Required(ErrorMessage = "Enter Valid Appraisal ID")]
        [DisplayName("Appraisal ID")]
        [Key]
        public int AppraisalID { get; set; }

        [Required(ErrorMessage = "Choose Valid Status")]
        [DisplayName("Appraisal Status")]
        public string AppraisalStatus { get; set; }

        [Required(ErrorMessage = "Enter Valid Employee ID")]
        [DisplayName("EmployeeID")]
        public int EmployeeID { get; set; }



        [Required(ErrorMessage = "Enter a Valid Objective")]
        [DisplayName("Objectives")]
        public string Objectives { get; set; }

        [Required(ErrorMessage = "Enter a valid Manager ID")]
        [DisplayName("Manager ID")]
        public int ManagerID { get; set; }


        [NotMapped]
        public int [] comps { get; set; }

        
        
    }
}
