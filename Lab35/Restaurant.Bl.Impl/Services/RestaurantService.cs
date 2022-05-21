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
    public class RestaurantService : IRestaurantService
    {
        private readonly IBackMapper<RestaurantEntity, RestaurantModel> _RestaurantMapper;
        private readonly IRestaurantRepository _RestaurantRepository;

        public RestaurantService(IBackMapper<RestaurantEntity, RestaurantModel> backMapper, IRestaurantRepository RestaurantRepository)
        {
            _RestaurantMapper = backMapper;
            _RestaurantRepository = RestaurantRepository;
        }

        public async Task<List<RestaurantModel>> GetAll()
        {
            List<RestaurantEntity> result = await _RestaurantRepository.GetAllAsync(x => true);
            return result.Select(_RestaurantMapper.Map).ToList();
        }

        public async Task<RestaurantModel> GetById(int id)
        {
            RestaurantEntity result = await _RestaurantRepository.GetRestaurantId(id);
            return _RestaurantMapper.Map(result);
        }

        public async Task DeleteById(int id)
        {
            await _RestaurantRepository.DeleteAsync(id);
        }

        public async Task Create(RestaurantModel model)
        {
            await _RestaurantRepository.AddAsync(_RestaurantMapper.BackMap(model));
        }
    }
}
