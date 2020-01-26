using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WepApi.MyRepository
{

    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected AppDbContext RepositoryContext { get; set; }

        public RepositoryBase(AppDbContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }

        public IQueryable<T> FindAll()
        {
            return RepositoryContext.Set<T>();
        }

        public T GetById(string Id)
        {
            return RepositoryContext.Set<T>().Find(Id);
        }

        public int Create(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);
            return RepositoryContext.SaveChanges();
        }
    }
}

