using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T GetSingle(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[]? includes);
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[]? includes);


        void Add(T item);

        void Remove(T item);
        void Update(T item); 

    }
}
