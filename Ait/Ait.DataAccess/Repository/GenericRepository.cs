using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ait.DataAccess.Repository
{
    public class GenericRepository<T>: IRepository<T> where T : class
    {
        protected AitContext context;

        public GenericRepository(AitContext context)
        {
            this.context = context;
        }

        public virtual T Add(T entity)
        {
            return context.Add(entity).Entity;
        }

        public virtual async Task<IEnumerable<T>> All()
        {
            return await context.Set<T>().ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            return await context.Set<T>().AsQueryable()
                                   .Where(predicate)
                                   .ToListAsync();
        }

        public virtual async Task<T> Get(int id)
        {
            return await context.FindAsync<T>(id);
        }

        public virtual async Task SaveChanges()
        {
            await context.SaveChangesAsync();
        }

        public virtual T Update(T entity)
        {
            return context.Update(entity).Entity;
        }
    }
}
