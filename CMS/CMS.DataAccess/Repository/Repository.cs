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

        public T GetSingle(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[]? includes)
        {
            IQueryable<T> query = dbSet;

            if (includes != null)
            {
                foreach (var include in includes)
                    query = query.Include(include);
            }
            return filter != null ? query.FirstOrDefault(filter) : query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[]? includes)
        {
            IQueryable<T> query = dbSet;

            if (includes != null)
            {
                foreach (var include in includes)
                    query = query.Include(include);

            }
            return filter != null ? query.Where(filter).ToList() : query.ToList();
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
