using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Bl.Abstract.IMapper;
using Restaurant.Entities;
using Restaurant.Models;

namespace Restaurant.Bl.Impl.Mappers
{
    public class RestaurantMapper : IBackMapper<RestaurantEntity, RestaurantModel>
    {
        public RestaurantModel Map(RestaurantEntity entity)
        {
            return new RestaurantModel()
            {
                Id = entity.Id,
                Address = entity.Address,
                Description = entity.Description,
                Name = entity.Name,
            };
        }

        public RestaurantEntity BackMap(RestaurantModel model)
        {
            return new RestaurantEntity()
            {
                Name = model.Name,
                Address = model.Address,
                Description = model.Description,
                Id = model.Id,
            };
        }
    }
}
