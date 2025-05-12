using CMS.BLL.DTO;
using CMS.DataAccess.Models;
using CMS.DataAccess.Models;
using CMS.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS.BLL.Manager
{
    public interface ICourseManager
    {
        IEnumerable<GetCourseDTO> GetAllCourses();
        GetCourseDTO GetCourseById(int id);
        void CreateCourse(CourseDTO courseDto);

        IEnumerable<Exams> GetExamsForCourse(int courseId);

        //IEnumerable<Exams> GetCourseExams(int courseId);
    }
}