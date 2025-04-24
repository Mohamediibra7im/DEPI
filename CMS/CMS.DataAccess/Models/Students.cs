
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Models
{
    public class Students 
    {
        public int Id { get; set; }                      // Auto Genrated
        public string IdNumber { get; set; }             // Custom ID (e.g., "20230001")  year + 4digit Last one is Id

        [Required]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "National ID must be exactly 14 characters long.")]
        public string NationalId { get; set; }     

        public string FirstName { get; set; }
        public string LastName { get; set; }


        [NotMapped]
        public string Email => $"{IdNumber}@college.edu.eg".ToLower();

        public DateOnly BirthDate { get; set; }
        public DateOnly EnrollmentDate { get; set; }
        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = " must be exactly 14 characters long.")]
        public string PhoneNumber {  get; set; }
        public string Address { get; set; }
        
        public decimal GPA { get; set; }
    }
}
