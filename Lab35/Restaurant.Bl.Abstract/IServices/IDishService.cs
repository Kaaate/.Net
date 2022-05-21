using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Models;

namespace Restaurant.Bl.Abstract.IServices
{
    public interface IDishService
    {
        Task<List<DishModel>> GetAll(int RestaurantId);
        Task DeleteById(int id);
        Task Create(DishModel model);
    }
}
