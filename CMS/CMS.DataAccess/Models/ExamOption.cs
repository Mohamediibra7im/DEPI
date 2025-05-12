using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CMS.Models
{
    public class ExamOption
    {
        [Key]
        public int OptionId { get; set; }

        public string OptionText { get; set; }
       
        public int QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        public  ExamQuestions Question { get; set; }

        public bool IsCorrect { get; set; }
    }
}
