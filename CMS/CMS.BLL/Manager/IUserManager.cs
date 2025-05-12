using CMS.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BLL.Manager
{
    public interface IUserManager
    {
        IEnumerable<UserReadDto> GetAll();
        //StudentReadDto Get (Expression<Func<StudentReadDto, bool>> filter);
        UserReadDto GetById(int id); 
        void Add(UserAddDto user);

        
        void Update(UserUpdateDto user);
    }
}
