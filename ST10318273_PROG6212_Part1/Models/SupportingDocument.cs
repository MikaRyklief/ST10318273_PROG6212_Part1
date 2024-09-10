namespace ST10318273_PROG6212_Part1.Models
{
    using System.ComponentModel.DataAnnotations;

    public class SupportingDocument
    {
        public int DocumentID { get; set; }

        [Required]
        public int ClaimID { get; set; }

        [Required]
        public string DocumentType { get; set; }

        [Required]
        public string FilePath { get; set; }

        public Claim Claim { get; set; }
    }
}