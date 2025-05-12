using CMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DataAccess.Models
{
    public class Courses
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string CourseCode { get; set; }
        [Required]
        [StringLength(100)]
        public string CourseName { get; set; } 

        public int Credits { get; set; } 
    
       

       
        public virtual ICollection<Exams> Exams { get; set; }

        //public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
    
    
}
