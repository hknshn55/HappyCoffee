using HappyCoffee.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffee.Core.DataAccess.Abstract
{
    public interface IRepository<T> where T: EntityBase,new()
    {
        Task<T> Get(Expression<Func<T,bool>> expression);
        Task<List<T>> GetAll(Expression<Func<T, bool>> expression = null);
        Task Add(T entity);
        Task Delete(T entity);
        Task Update(T entity);

    }
}
