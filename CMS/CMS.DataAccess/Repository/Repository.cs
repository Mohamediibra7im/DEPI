using CMS.Data;
using CMS.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicaionDbContext _db;
        internal DbSet<T> dbSet;
        public Repository(ApplicaionDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }
        public void Add(T item)
        {
            dbSet.Add(item);
        }

        //public T Get(Expression<Func<T, bool>> filter)
        //{
        //IQueryable<T> query = dbSet.Where(filter).AsNoTracking();

        //return query.FirstOrDefault();
        //}

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;

            return query.ToList();
        }

        public void Remove(T item)
        {
            dbSet.Remove(item);
        }

        public void Update(T item)
        {
           dbSet.Update(item);
        }
    }
}
