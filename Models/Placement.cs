using System.ComponentModel.DataAnnotations;

namespace PlacementApp.Models
{
    public class Placement
    {
        [Required]
        [Display(Name = "Candidate Name")]
        public string CandidateName { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email ID")]
        public string EmailID { get; set; }

        [Display(Name = "Visa Status")]
        public string VisaStatus { get; set; }

        [Display(Name = "Current Location")]
        public string CurrentLocation { get; set; }

        [Display(Name = "Client Name")]
        public string ClientName { get; set; }

        [Display(Name = "Role Title")]
        public string RoleTitle { get; set; }

        [Display(Name = "Project Location")]
        public string ProjectLocation { get; set; }

        [Display(Name = "Employer Name")]
        public string EmployerName { get; set; }

        [Display(Name = "Employer POC")]
        public string EmployerPOC { get; set; }

        [EmailAddress]
        [Display(Name = "Employer Email")]
        public string EmployerEmail { get; set; }

        [Phone]
        [Display(Name = "Employer Phone")]
        public string EmployerPhone { get; set; }
    }
}
