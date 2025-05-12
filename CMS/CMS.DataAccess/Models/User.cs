
using CMS.DataAccess.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Models
{
    public class User
    {
        public int Id { get; set; }                      // Auto Genrated
        public string IdNumber { get; set; }             // Custom ID (e.g., "20230001")  year + 4digit Last one is Id

        [Required]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "National ID must be exactly 14 characters long.")]
        public string NationalId { get; set; }
        [Required]
        public string FullName { get; set; }
       


        [NotMapped]
        public string Email => $"{IdNumber}@college.edu.eg".ToLower();

        public DateOnly BirthDate { get; set; }
        public DateOnly EnrollmentDate { get; set; }
        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = " must be exactly 14 characters long.")]
        public string PhoneNumber {  get; set; }
        public string Address { get; set; }
        
        public decimal GPA { get; set; }

        //[Required]
        //public byte[] PasswordHash { get; set; } = Array.Empty<byte>();

        //[Required]
        //public byte[] PasswordSalt { get; set; } = Array.Empty<byte>();

        //public string? RefreshToken { get; set; }
        //public DateTime? RefreshTokenExpiry { get; set; }

        //public UserRole Role { get; set; } = UserRole.Student; // Default to Student


        //public string GetRoleByIndex(int roleIndex)
        //{
        //    return roleIndex switch
        //    {
        //        0 => UserRole.Student.ToString(),
        //        1 => UserRole.Teacher.ToString(),
        //        2 => UserRole.Admin.ToString(),
        //        _ => "Unknown"
        //    };
        //}

    }
}
