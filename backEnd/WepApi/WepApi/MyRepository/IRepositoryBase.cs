using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WepApi.MyRepository
{
    interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        T GetById(string Id);
        int Create(T entity);
    }
}
