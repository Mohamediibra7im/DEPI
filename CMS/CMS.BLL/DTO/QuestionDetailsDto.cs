using CMS.DataAccess.Models;
using CMS.Models;
using System.Collections.Generic;

namespace CMS.BLL.DTO
{
    public class QuestionDetailsDto
    {
        public int ExamQuestionsId { get; set; }
        public string QuestionText { get; set; }
        public QuestionType QuestionType { get; set; }
        public int Marks { get; set; }
        public int ExamId { get; set; }
        public List<OptionDetailsDto> Options { get; set; } = new();
    }
}
