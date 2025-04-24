using CMS.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BLL.Manager
{
    public interface IStudentManager
    {
        IEnumerable<StudentReadDto> GetAll();
        //StudentReadDto Get (Expression<Func<StudentReadDto, bool>> filter);
        StudentReadDto GetById(int id); 
        void Add(StudentAddDto item);

        
        void Update(StudentUpdateDto item);
    }
}
