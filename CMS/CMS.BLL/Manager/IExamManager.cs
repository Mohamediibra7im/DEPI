using CMS.Models;

namespace CMS.BLL.Manager
{
    public interface IExamManager
    {
        IEnumerable<Exams> GetAllExams();
        Exams GetExamById(int id);
        Exams CreateExam(Exams exam);
        //Task<Exams> UpdateExam(int id, Exams examDto);
        //bool DeleteExam(int id);
        IEnumerable<Exams> GetExamsByCourseId(int courseId);

        // Question Management
        ExamQuestions AddQuestionToExam(int examId, ExamQuestions question);
        IEnumerable<ExamQuestions> GetExamQuestions(int examId);
        //ExamQuestions UpdateExamQuestion(int questionId, ExamQuestions questionDto);
    }
}
