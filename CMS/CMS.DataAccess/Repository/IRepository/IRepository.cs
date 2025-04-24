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
        IEnumerable<T> GetAll();
        //T Get(Expression<Func<T, bool>> filter);

        T GetById(int id);
        void Add(T item);

        void Remove(T item);
        void Update(T item); 

    }
}
