using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurant.Bl.Abstract.IServices;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {

        private readonly ILogger<OrderController> _logger;
        private readonly IDishService _menuService;

        public MenuController(ILogger<OrderController> logger, IDishService menuService)
        {
            _logger = logger;
            _menuService = menuService;
        }

        [HttpGet]
        [Route("GetAll/{restaurantId}")]
        public async Task<List<DishModel>> GetAll(int restaurantId)
        {
            return await _menuService.GetAll(restaurantId);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([FromBody]DishModel dishModel)
        {
            await _menuService.Create(dishModel);
            return Ok();
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _menuService.DeleteById(id);
            return Ok();
        }
    }
}
