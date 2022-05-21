using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Dal.Abstract.Repository;
using Restaurant.Dal.Ef.Postgres.Repository.Base;
using Restaurant.Entities;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Dal.Ef.Postgres.Repository
{
    public class RestaurantRepository : GenericKeyRepository<int, RestaurantEntity>, IRestaurantRepository
    {
        public RestaurantRepository() : base(DbContextManager.RestaurantDbContext)
        {

        }

        public async Task<RestaurantEntity> GetRestaurantId(int id)
        {
            var result = Context.Restaurant.
                Where(h => h.Id == id)
                .FirstOrDefaultAsync();

            return await result;
        }
    }
}
