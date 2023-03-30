namespace EmployeeAppraisal.Models
{
    public class AppraisalModelBase2
    {
        [Key]
        [Required]
        public int DetailID { get; set; }
        [Required(ErrorMessage = "Enter Valid ID")]
        [DisplayName("DetailID")]
        public string AppraisalID { get; set; }
        [Required(ErrorMessage = "Enter Appraisal ID")]
        [DisplayName("Appraisal ID")]
        public string Competency { get; set; }
        [Required(ErrorMessage = "Choose Valid Competency")]
        [DisplayName("Competency")]
        public string EmployeeRating { get; set; }
        [Required(ErrorMessage = "Choose Valid Rating Value")]
        [DisplayName("EmployeeRating")]
        public string EmployeeComments { get; set; }
        [Required(ErrorMessage = "Give Valid Comments")]
        [DisplayName("EmployeeComments")]
        public string ManagerRating { get; set; }
        [Required(ErrorMessage = "Enter Valid Rating")]
        [DisplayName("ManagerRating")]
        public string ManagerComments { get; set; }
    }
}