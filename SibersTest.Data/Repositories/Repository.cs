using Microsoft.EntityFrameworkCore;
using SibersTest.Data.Entities;
using SibersTest.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SibersTest.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly DbContext context;

        public Repository(DbContext context)
        {
            this.context = context;
        }

        public T Get(int id)
        {
            return context.Set<T>().Find(id);
        }
            
        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate);
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
        }
    }
}
