using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Models
{
    public class Students 
    {
        public int Id { get; set; }                      // Auto Genrated
        public string IdNumber { get; set; }             // Custom ID (e.g., "20230001")  year + 4digit Last one is Id
        public string NationalId { get; set; }     

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email => $"{IdNumber}@college.edu.eg".ToLower();
        public DateOnly BirthDate { get; set; }
        public DateOnly EnrollmentDate { get; set; }
        public string PhoneNumber {  get; set; }
        public string Address { get; set; }
        [Column(TypeName = "decimal(3,2)")]
        public decimal GPA { get; set; }
    }
}
