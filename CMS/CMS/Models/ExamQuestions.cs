namespace CMS.Models
{
    public class ExamQuestions
    {
        public int ExamQuestionsId { get; set; } // Primary Key
        public string QuestionText { get; set; }
        public string QuestionType { get; set; } // Ex: MCQ, True/False, Short Answer
        public int Marks { get; set; }
        public string ExamId { get; set; }    // -> Foreign key to Exams table
        public int CourseId { get; set; }     // -> Foreign key to Courses table
    }
}
