using CMS.Models;
using CMS.DataAccess.Repository.IRepository;

namespace CMS.BLL.Manager
{
    public class ExamManager : IExamManager
    {
        private readonly IExamRepository _examRepository;
        private readonly IQuestionExamRepository _questionRepository;


        public ExamManager(IExamRepository examRepository, IQuestionExamRepository questionExamRepository)
        {
            _examRepository = examRepository;
            _questionRepository = questionExamRepository;


        }

        public Exams GetExamById(int id)
        {
            return _examRepository.GetSingle(
                e => e.ExamsId == id,
                e => e.Course,
                e => e.ExamQuestions);
        }

        public IEnumerable<Exams> GetAllExams()
        {
            return _examRepository.GetAll(
                null, 
                e => e.Course,
                e => e.ExamQuestions);
        }

        public Exams CreateExam(Exams exam)
        {
            _examRepository.Add(exam);

            return exam;
        }

        //public Exams UpdateExam(int id, Exams exam)
        //{
        //    var exams = _examRepository.GetById(id);
        //    if (exam == null)
        //        return null;


        //    exam.Examtype = exam.Examtype;
        //    exam.DurationMinutes = exam.DurationMinutes;
        //    exam.ExamDate = exam.ExamDate;
        //    exam.TotalMarks = exam.TotalMarks;
        //    exam.CourseId = exam.CourseId;

        //    _examRepository.Update(exam);
        //    _examRepository.Save();
        //    return exam;
        //}

        //public bool DeleteExam(int id)
        //{
        //    var exam = _examRepository.GetById(id);


        //    _examRepository.Remove(exam);
        //    _examRepository.Save();
        //    return true;
        //}

        //public async Task<IEnumerable<Exams>> GetExamsByCourseAsync(int courseId)
        //{
        //    return  _examRepository.(e => e.CourseId == courseId);
        //}

        public ExamQuestions AddQuestionToExam(int examId, ExamQuestions questionDto)
        {
            var question = new ExamQuestions
            {
                ExamId = examId,
                QuestionText = questionDto.QuestionText,
                QuestionType = questionDto.QuestionType,
                Marks = questionDto.Marks,
                Options = new List<ExamOption>()
            };

            foreach (var optionDto in questionDto.Options)
            {
                question.Options.Add(new ExamOption
                {
                    OptionText = optionDto.OptionText,
                    IsCorrect = optionDto.IsCorrect,
                });
            }

            _questionRepository.Add(question);
            _questionRepository.Save();

            return question;
        }


        public IEnumerable<ExamQuestions> GetExamQuestions(int examId)
        {
            return _questionRepository.GetAll(examId);
        }

       
        public IEnumerable<Exams> GetExamsByCourseId(int courseId)
        {
            return _examRepository.GetAll(
                e => e.CourseId == courseId,
                e => e.Course,
                e => e.ExamQuestions
            );
        }

    }
}
