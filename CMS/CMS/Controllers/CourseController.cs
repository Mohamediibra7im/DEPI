using CMS.BLL.DTO;
using CMS.BLL.Manager;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseManager _courseManager;

        public CourseController(ICourseManager courseManager)
        {
            _courseManager = courseManager;
        }

        [HttpPost]
        public IActionResult CreateCourse([FromBody] CourseDTO courseDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _courseManager.CreateCourse(courseDto);
            return Created();
        }

        [HttpGet]
        public IActionResult GetAllCourses()
        {
            var courses = _courseManager.GetAllCourses();
            return Ok(courses);
        }

        [HttpGet("{id}/exams")]
        public IActionResult GetExamsForCourse(int id)
        {
            var exams = _courseManager.GetExamsForCourse(id);

            if (exams == null || !exams.Any())
                return NotFound("No exams found for this course.");

            IEnumerable<GetCourseExamsDto>? examDtos = exams.Select(e => new GetCourseExamsDto
            {
                ExamsId = e.ExamsId,
                Examtype = e.Examtype,
                DurationMinutes = e.DurationMinutes,
                ExamDate = e.ExamDate,
                TotalMarks = e.TotalMarks,
            });

            return Ok(examDtos);
        }


        [HttpGet("{id}")]
        public IActionResult GetCourseById(int id)
        {
            var course = _courseManager.GetCourseById(id);
            if (course == null)
                return NotFound("Course not found");

            return Ok(course);
        }
    }
}