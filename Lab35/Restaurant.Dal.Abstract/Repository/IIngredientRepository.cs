using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Dal.Abstract.Repository.Base;
using Restaurant.Entities;
using Restaurant.Models;

namespace Restaurant.Dal.Abstract.Repository
{
    public interface IIngredientRepository : IGenericKeyRepository<int, Ingredient>
    {

    }
 
}
