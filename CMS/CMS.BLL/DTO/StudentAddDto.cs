using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BLL.DTO
{
    public class StudentAddDto
    {
        [Required]
        [RegularExpression(@"^\d{14}$", ErrorMessage = " National Id must contain only digits and be 14 characters long.")]
        [StringLength(14, MinimumLength = 14)]
        public string NationalId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateOnly BirthDate { get; set; }
        [Required]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Phone number must contain only digits and be 11 characters long.")]
        [StringLength(11, MinimumLength = 11)]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }

    }
}
