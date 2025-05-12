using CMS.Data;
using CMS.DataAccess.Models;
using CMS.DataAccess.Repository.IRepository;
using CMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DataAccess.Repository
{
    public class QuestionExamRepository : Repository<ExamQuestions>, IQuestionExamRepository
    {
        private readonly ApplicaionDbContext _db;
        public QuestionExamRepository(ApplicaionDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<ExamQuestions> GetAll(int examsid)
        {
            IQueryable<ExamQuestions> query = dbSet
               .Include(q => q.Options)
               .Where(q => q.ExamId == examsid);

            return query.ToList();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
    
}
