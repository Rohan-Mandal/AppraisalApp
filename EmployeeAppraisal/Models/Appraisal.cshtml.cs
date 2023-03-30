using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeAppraisal.Models
{
    public class AppraisalModel : AppraisalModelBase2
    {
        [Required(ErrorMessage = "Enter Valid Comments")]
            [DisplayName("ManagerComments")]




    }
}
