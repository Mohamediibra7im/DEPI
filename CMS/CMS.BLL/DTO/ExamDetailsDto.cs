using CMS.DataAccess.Models;

namespace CMS.BLL.DTO
{
    public class ExamDetailsDto
    {
        public int ExamsId { get; set; }
        public string Examtype { get; set; }
        public int DurationMinutes { get; set; }
        public DateTime ExamDate { get; set; }
        public int TotalMarks { get; set; }

        public CourseDto? Course { get; set; }
        public List<QuestionDto> Questions { get; set; } = new();
    }

    public class GetCourseExamsDto
    {
        public int ExamsId { get; set; }
        public string Examtype { get; set; }
        public int DurationMinutes { get; set; }
        public DateTime ExamDate { get; set; }
        public int TotalMarks { get; set; }
    }
}

    public class CourseDto
    {
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
    }

    public class QuestionDto
    {
        public int ExamQuestionsId { get; set; }
        public string QuestionText { get; set; }
        public QuestionType QuestionType { get; set; }
        public int Marks { get; set; }
        public List<OptionDto> Options { get; set; } = new();
    }

    public class OptionDto
    {
        public int OptionId { get; set; }
        public string OptionText { get; set; }
        public bool IsCorrect { get; set; }
    }

