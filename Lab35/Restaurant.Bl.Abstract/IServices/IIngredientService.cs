using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Models;

namespace Restaurant.Bl.Abstract.IServices
{
    public interface IIngredientService
    {
        Task<List<IngredientModel>> GetAll();
        Task DeleteById(int id);
        Task Create(IngredientModel model);
    }
}
