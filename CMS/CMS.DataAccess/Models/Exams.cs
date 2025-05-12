using CMS.DataAccess.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace CMS.Models
{
    public class Exams
    {
        public int ExamsId { get; set; } // Primary Key
        
        public string Examtype { get; set; } // Ex: Midterm, Final, Quiz
        [Required]
        public int DurationMinutes { get; set; } // in minutes
        public DateTime ExamDate { get; set; }
        public int TotalMarks { get; set; }
        public int CourseId { get; set; } // Foreign key to Courses table

        public  Courses ? Course { get; set; }
        public virtual ICollection<ExamQuestions> ExamQuestions { get; set; }


    }
}
