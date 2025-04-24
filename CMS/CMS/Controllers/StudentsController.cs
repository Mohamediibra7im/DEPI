using CMS.BLL.DTO;
using CMS.BLL.Manager;
using CMS.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentManager _studentManager;
        public StudentsController(IStudentManager studentManager)
        {
            _studentManager = studentManager;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_studentManager.GetAll());
        }
        [HttpGet("{Id}")]
        public ActionResult GetById(int Id)
        {
            return Ok(_studentManager.GetById(Id));
        }
        [HttpPost]
        public ActionResult Add(StudentAddDto studentAddDto)
        {

            if (ModelState.IsValid)
            {
                _studentManager.Add(studentAddDto);
                return NoContent();
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{Id}")]
        public ActionResult Update(int Id, StudentUpdateDto studentUpdateDto)
        {
            if (Id != studentUpdateDto.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                _studentManager.Update(studentUpdateDto);
                return NoContent();
            }
            return BadRequest(ModelState);

        }

    }
}
