namespace CMS.Models
{
    public class Grades
    {
        public int GradesId { get; set; } // Primary Key
        public string StudentId { get; set; } // Foreign key to Students table
        public int CourseId { get; set; } // Foreign key to Courses table
        public int ExamId { get; set; } // Foreign key to Exams table
        public int MarksObtained { get; set; }
        public int TotalMarks { get; set; }
        public string Grade { get; set; } // Ex: A, A+, A-, B, B-, B+, C, D, F
        public DateTime DateRecorded { get; set; }
    }
}
