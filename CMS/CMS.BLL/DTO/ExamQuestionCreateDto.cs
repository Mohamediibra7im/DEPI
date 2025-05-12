using CMS.DataAccess.Models;
using System.ComponentModel.DataAnnotations;

namespace CMS.BLL.DTO;

public class ExamQuestionCreateDto
{
    [Required]
    public string QuestionText { get; set; }

    [Required]
    public QuestionType QuestionType { get; set; }

    [Required]
    public int Marks { get; set; }

    public List<ExamOptionCreateDto>? Options { get; set; }
}

public class ExamOptionCreateDto
{
    [Required]
    public string OptionText { get; set; }
    public bool IsCorrect { get; set; }
}