using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Bl.Abstract.IMapper;
using Restaurant.Entities;
using Restaurant.Models;

namespace Restaurant.Bl.Impl.Mappers
{
    public class IngredientMapper : IBackMapper<Ingredient, IngredientModel>
    {
        public IngredientModel Map(Ingredient entity)
        {
            return new IngredientModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Description =  entity.Description,
            };
        }

        public Ingredient BackMap(IngredientModel model)
        {
            return new Ingredient()
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
            };
        }
    }
}
