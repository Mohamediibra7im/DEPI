using System.ComponentModel.DataAnnotations;

namespace CMS.BLL.DTO.Requests.user
{
    public class UpdateUserDto
    {
        [MaxLength(100, ErrorMessage = "First name cannot exceed 100 characters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "First name can only contain letters")]
        public string? FullName { get; set; }


        [EmailAddress(ErrorMessage = "Invalid email format")]
        [MaxLength(255, ErrorMessage = "Email cannot exceed 255 characters")]
        public string? Email { get; set; }

    }
}