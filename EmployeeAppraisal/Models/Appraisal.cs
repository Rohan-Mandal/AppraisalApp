using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAppraisal.Models
{
    public class Appraisal
    {
        [Key]
        [Required(ErrorMessage = "Enter Valid ID")]
        [DisplayName("DetailID")]
        public int DetailID { get; set; } = 0;

        [Required(ErrorMessage = "Enter Appraisal ID")]
        [DisplayName("Appraisal ID")]
        public string AppraisalID { get; set; }

        
        [Required(ErrorMessage = "Choose Valid Rating Value")]
        [DisplayName("EmployeeRating")]
        public string EmployeeRating { get; set; }

        [Required(ErrorMessage = "Give Valid Comments")]
        [DisplayName("EmployeeComments")]
        public string EmployeeComments { get; set; }

        [Required(ErrorMessage = "Enter Valid Rating")]
        [DisplayName("ManagerRating")]
        public string ManagerRating { get; set; }
        [Required(ErrorMessage = "Enter Valid Comment")]
        [DisplayName("ManagerComments")]

        public string Objectives { get; set; }
        [Required(ErrorMessage = "Enter Valid Objectives")]
        [DisplayName("Objectives")]

        public string ManagerComments { get; set; }

        [Required(ErrorMessage = "Choose Valid Competency")]
        [DisplayName("Competency")]
        public string Competency { get; set; } = null;

        [Required(ErrorMessage = "Enter Valid EID")]
        [DisplayName("EmployeeID")]
        public int EmployeeID { get; set; } = 0;
    }
}
