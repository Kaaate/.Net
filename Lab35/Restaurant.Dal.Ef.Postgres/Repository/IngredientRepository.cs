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
    public class IngredientRepository : GenericKeyRepository<int, Ingredient>, IIngredientRepository
    {
        public IngredientRepository() : base(DbContextManager.RestaurantDbContext)
        {

        }

    }
}
