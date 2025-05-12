using CMS.BLL.DTO;
using CMS.BLL.Manager;
using CMS.DataAccess.Models;
using CMS.DataAccess.Repository.IRepository;
using CMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController(IExamManager examManager, IQuestionExamRepository questionExamRepository) : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetExamById(int id)
        {
            var exam = examManager.GetExamById(id);
            if (exam == null)
                return NotFound("Exam not found");

            var examDto = new ExamDetailsDto
            {
                ExamsId = exam.ExamsId,
                Examtype = exam.Examtype,
                DurationMinutes = exam.DurationMinutes,
                ExamDate = exam.ExamDate,
                TotalMarks = exam.TotalMarks,
                Course = exam.Course == null ? null : new CourseDto
                {
                    CourseId = exam.Course.CourseId,
                    CourseCode = exam.Course.CourseCode,
                    CourseName = exam.Course.CourseName,
                    Credits = exam.Course.Credits
                },
                Questions = exam.ExamQuestions?.Select(q => new QuestionDto
                {
                    ExamQuestionsId = q.ExamQuestionsId,
                    QuestionText = q.QuestionText,
                    QuestionType = q.QuestionType,
                    Marks = q.Marks,
                    Options = q.Options?.Select(o => new OptionDto
                    {
                        OptionId = o.OptionId,
                        OptionText = o.OptionText,
                        IsCorrect = o.IsCorrect
                    }).ToList() ?? new()
                }).ToList() ?? new()
            };

            return Ok(examDto);
        }


        [HttpPost]
        public IActionResult CreateExam(ExamCreateDto examDto)
        {
            var exam = new Exams
            {
                Examtype = examDto.Examtype,
                DurationMinutes = examDto.DurationMinutes,
                ExamDate = examDto.ExamDate,
                TotalMarks = examDto.TotalMarks,
                CourseId = examDto.CourseId
            };

            var createdExam = examManager.CreateExam(exam);

            // Add questions
            if (examDto.Questions != null)
            {
                foreach (var questionDto in examDto.Questions)
                {
                    var options = questionDto.Options?.Select(o => new ExamOption
                    {
                        OptionText = o.OptionText,
                        IsCorrect = o.IsCorrect
                    }).ToList();

                    var question = new ExamQuestions
                    {
                        ExamId = createdExam.ExamsId,
                        QuestionText = questionDto.QuestionText,
                        QuestionType = questionDto.QuestionType,
                        Marks = questionDto.Marks,
                        Options = options
                    };

                    examManager.AddQuestionToExam(createdExam.ExamsId, question);
                }
            }

            return Created();
        }
    }
}
