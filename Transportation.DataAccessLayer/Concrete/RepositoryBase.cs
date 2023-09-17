using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Transportation.DataAccessLayer.Context;
using Transportation.DataAccessLayer.Contracts;

namespace Transportation.DataAccessLayer.Concrete
{
    public abstract class RepositoryBase<T>:IRepositoryBase<T>
        where T : class,new()
    {
        protected readonly TransportationContext _context;

        protected RepositoryBase(TransportationContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public T? FindByCondition(Expression<Func<T, bool>> expression)
        {
          return  _context.Set<T>().Where(expression).SingleOrDefault();
        }

        public List<T> GetAll()
        {
           return _context.Set<T>().ToList();
        }

        

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
