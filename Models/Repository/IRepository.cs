using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Sandbox.Models.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
		IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T dbEntity, T entity);
        void Delete(T entity);
    }
}
