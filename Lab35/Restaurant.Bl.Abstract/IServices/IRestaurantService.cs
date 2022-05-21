using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Models;

namespace Restaurant.Bl.Abstract.IServices
{
    public interface IRestaurantService
    {
        Task<List<RestaurantModel>> GetAll();
        Task<RestaurantModel> GetById(int id);
        Task DeleteById(int id);
        Task Create(RestaurantModel model);
    }
}
