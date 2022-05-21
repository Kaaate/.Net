using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Dal.Ef.Postgres
{
    public class DbContextManager
    {
        private static RestaurantDbContext _RestaurantDbContext = null;
        public static RestaurantDbContext RestaurantDbContext
        {
            get => _RestaurantDbContext ??= new RestaurantDbContext();
            private set => _RestaurantDbContext = value;
        }
    }
}
