using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DataAccess.Repository.IRepository
{
    public interface IQuestionExamRepository:IRepository<ExamQuestions>
    {
        IEnumerable<ExamQuestions> GetAll(int examid);


        void Save();
    }
    
}
