using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Bl.Abstract.IMapper;
using Restaurant.Bl.Abstract.IServices;
using Restaurant.Dal.Abstract.Repository;
using Restaurant.Entities;
using Restaurant.Models;

namespace Restaurant.Bl.Impl.Services
{
    public class DishService : IDishService
    {
        private readonly IBackMapper<Dish, DishModel> _dishMapper;
        private readonly IDishRepository _dishRepository;

        public DishService(IBackMapper<Dish, DishModel> dishMapper, IDishRepository dishRepository)
        {
            _dishMapper = dishMapper;
            _dishRepository = dishRepository;
        }


        public async Task<List<DishModel>> GetAll(int RestaurantId)
        {
            List<Dish> result = await _dishRepository.GetAllAsync(x => x.RestaurantId == RestaurantId);
            return result.Select(_dishMapper.Map).ToList();
        }


        public async Task DeleteById(int id)
        {
            await _dishRepository.DeleteAsync(id);
        }

        public async Task Create(DishModel model)
        {
            await _dishRepository.AddAsync(_dishMapper.BackMap(model));
        }
    }
}
