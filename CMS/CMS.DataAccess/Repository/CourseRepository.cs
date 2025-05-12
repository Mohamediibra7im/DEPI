using CMS.Data;
using CMS.DataAccess.Models;
using CMS.DataAccess.Repository.IRepository;
using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DataAccess.Repository
{
    public class CourseRepository : Repository<Courses>, ICourseRepository
    {
        private readonly ApplicaionDbContext _db;
        public CourseRepository(ApplicaionDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }

    
}
