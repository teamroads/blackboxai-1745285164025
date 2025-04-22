using System.ComponentModel.DataAnnotations;

namespace PlacementApp.Models
{
    public class PlacementInfo
    {
        public PlacementInfo()
        {
            CandidateName = string.Empty;
            PhoneNumber = string.Empty;
            EmailID = string.Empty;
            TypeOfHire = string.Empty;
        }

        [Required]
        [Display(Name = "Candidate Name")]
        public string? CandidateName { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email ID")]
        public string? EmailID { get; set; }

        [Display(Name = "Visa Status")]
        public string? VisaStatus { get; set; }

        [Display(Name = "Current Location")]
        public string? CurrentLocation { get; set; }

        [Display(Name = "Client Name")]
        public string? ClientName { get; set; }

        [Display(Name = "Role Title")]
        public string? RoleTitle { get; set; }

        [Display(Name = "Project Location")]
        public string? ProjectLocation { get; set; }

        [Display(Name = "Employer Name")]
        public string? EmployerName { get; set; }

        [Display(Name = "Employer POC")]
        public string? EmployerPOC { get; set; }

        [EmailAddress]
        [Display(Name = "Employer Email")]
        public string? EmployerEmail { get; set; }

        [Phone]
        [Display(Name = "Employer Phone")]
        public string? EmployerPhone { get; set; }

        [Required]
        [Display(Name = "Type of Hire")]
        public string? TypeOfHire { get; set; }

        [Display(Name = "Apply Referral")]
        public bool? ApplyReferral { get; set; }

        [Display(Name = "Referral Fees")]
        public decimal? ReferralFees { get; set; }

        [Display(Name = "Pay Rate")]
        public decimal? PayRate { get; set; }

        [Display(Name = "SRP")]
        public decimal? SRP { get; set; }

        [Display(Name = "Margin")]
        public decimal? Margin { get; set; }

        [Display(Name = "Recruiter's Name")]
        public string? RecruiterName { get; set; }
    }
}
