﻿using CMS.Data;
using CMS.DataAccess.Repository.IRepository;
using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DataAccess.Repository
{
    public class StudentRepository : Repository<Students>, IStudentRepository
    {
        private readonly ApplicaionDbContext _db;
        public StudentRepository(ApplicaionDbContext db) :base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
    
    
}
