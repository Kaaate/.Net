using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Restaurant.Models;

namespace Restaurant.Dal.Abstract.Repository.Base
{
    public interface IGenericKeyRepository<TKey, TEntity>
    {
        Task<TEntity> AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TKey id);
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetByIdAsync(TKey id);
        Task<int> GetCountAsync();
    }
}
