using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DataAccess.Repository.IRepository
{
    public interface IExamRepository:IRepository<Exams>
    {
        
        void Save();
    }
    
}
