using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Bl.Abstract.IMapper;
using Restaurant.Entities;
using Restaurant.Models;

namespace Restaurant.Bl.Impl.Mappers
{
    public class DishMapper : IBackMapper<Dish, DishModel>
    {
        public DishModel Map(Dish entity)
        {
            return new DishModel()
            {
                Id = entity.Id,
                RestaurantId = entity.RestaurantId,
                Name = entity.Name,
                Price = entity.Price,
                Recipe = entity.Recipe,
            };
        }

        public Dish BackMap(DishModel model)
        {
            return new Dish()
            {
                Id = model.Id,
                RestaurantId = model.RestaurantId,
                Name = model.Name,
                Recipe = model.Recipe,
                Price = model.Price,
            };
        }
    }
}
