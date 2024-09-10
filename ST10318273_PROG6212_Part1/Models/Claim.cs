namespace ST10318273_PROG6212_Part1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Claim
    {
        public int ClaimID { get; set; }

        [Required]
        public string LecturerName { get; set; }

        [Required]
        public DateTime ClaimDate { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        [Required]
        public string Status { get; set; } // e.g., Submitted, Approved, Rejected

        public ICollection<SupportingDocument> SupportingDocuments { get; set; } = new List<SupportingDocument>();
    }
}