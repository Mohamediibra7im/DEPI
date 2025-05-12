using CMS.DataAccess.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Models
{
    public class ExamQuestions
    {
        public int ExamQuestionsId { get; set; } // Primary Key
        public string QuestionText { get; set; }
        public QuestionType QuestionType { get; set; }

        public int Marks { get; set; }
        public int ExamId { get; set; }
       
        public virtual Exams ? exams { get; set; }
        public virtual ICollection<ExamOption> Options { get; set; }

    }
}
