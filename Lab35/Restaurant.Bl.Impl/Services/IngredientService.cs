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
    public class IngredientService : IIngredientService
    {
        private readonly IBackMapper<Ingredient, IngredientModel> _ingredientMapper;
        private readonly IIngredientRepository _ingredientRepository;

        public IngredientService(IBackMapper<Ingredient, IngredientModel> ingredientMapper, IIngredientRepository ingredientRepository)
        {
            _ingredientMapper = ingredientMapper;
            _ingredientRepository = ingredientRepository;
        }

        public async Task<List<IngredientModel>> GetAll()
        {
            List<Ingredient> result = await _ingredientRepository.GetAllAsync(x => true);
            return result.Select(_ingredientMapper.Map).ToList();
        }


        public async Task DeleteById(int id)
        {
            await _ingredientRepository.DeleteAsync(id);
        }

        public async Task Create(IngredientModel model)
        {
            await _ingredientRepository.AddAsync(_ingredientMapper.BackMap(model));
        }
    }
}
