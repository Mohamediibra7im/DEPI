using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMS.BLL.DTO
{
    public class CourseDTO
    {
        [Required]
        [StringLength(100)]
        public string CourseName { get; set; }

        [Required]
        public string CourseCode { get; set; }

        [Required]
        public int Credits { get; set; }
    }
}