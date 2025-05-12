using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BLL.DTO
{
    public class UserUpdateDto

    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^\d{14}$", ErrorMessage = "National ID must be exactly 14 characters long.")]
        [StringLength(14, MinimumLength = 14)]
        public string NationalId { get; set; }
        [Required]
        public string FullName { get; set; }
      
        [Required]
        public DateOnly BirthDate { get; set; }
        [Required]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Phone number must contain only digits and be 11 characters long.")]
        [StringLength(11, MinimumLength = 11)]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Column(TypeName = "decimal(3,2)")]
        public decimal GPA { get; set; }
    }
}
