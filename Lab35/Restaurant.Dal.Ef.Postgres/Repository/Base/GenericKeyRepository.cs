using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Dal.Abstract.Repository.Base;
using Restaurant.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Restaurant.Dal.Ef.Postgres.Repository.Base
{
    public abstract class GenericKeyRepository<TKey, TEntity> : IGenericKeyRepository<TKey, TEntity>
        where TEntity : class
    {
        public RestaurantDbContext Context;
        public DbSet<TEntity> DbSet => Context.Set<TEntity>();

        public GenericKeyRepository(RestaurantDbContext context)
        {
            Context = context;
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            EntityEntry<TEntity> item = await DbSet.AddAsync(entity);
            await Context.SaveChangesAsync();
            return item.Entity;
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            Context.Update(entity);
            await Context.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(TKey id)
        {
            TEntity item = await DbSet.FindAsync(id);
            DbSet.Remove(item);
            await Context.SaveChangesAsync();
        }

 
        public virtual async Task<TEntity> GetByIdAsync(TKey key)
        {
            TEntity item = await DbSet.FindAsync(key);
            return item;
        }

        public virtual async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate)
        {
            List<TEntity> item = await DbSet.Where(predicate).ToListAsync();
            return item;
        }

        public virtual async Task<int> GetCountAsync()
        {
            int item = await DbSet.CountAsync();
            return item;
        }
    }
}
