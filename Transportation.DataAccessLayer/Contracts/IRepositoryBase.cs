﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.DataAccessLayer.Contracts
{
    public interface IRepositoryBase<T>
    {
        List<T> GetAll();
        T? FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        

    }
}
