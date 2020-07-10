using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ait.DataAccess.Repository
{
    public interface IRepository<T>
    {
        T Add(T entity);
        T Update(T entity);
        Task<T> Get(int id);
        Task<IEnumerable<T>> All();
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
        Task SaveChanges();
    }
}
