namespace CMS.Models
{
    public class Exams
    {
        public int ExamsId { get; set; } // Primary Key
        public string ExamName { get; set; }
        public string Examtype { get; set; } // Ex: Midterm, Final, Quiz
        public int Duration { get; set; } // in minutes
        public DateTime ExamDate { get; set; }
        public int TotalMarks { get; set; }
        public int CourseId { get; set; } // Foreign key to Courses table
        public int FacultyId { get; set; } // Foreign key to Faculty table
    }
}
