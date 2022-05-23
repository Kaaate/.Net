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
    public class OrderController : ControllerBase
    {

        private readonly ILogger<OrderController> _logger;
        private readonly IOrderService _orderService;

        public OrderController(ILogger<OrderController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<List<OrderModel>> GetAll()
        {
            return await _orderService.GetAll();
        }

        [HttpGet]
        [Route("FindByPhoneNumber/{phoneNumber}")]
        public async Task<OrderModel> FindByPhoneNumber(string phoneNumber)
        {
            return await _orderService.GetByPhoneNumber(phoneNumber);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([FromBody]OrderModel orderModel)
        {
            await _orderService.Create(orderModel);
            return Ok();
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _orderService.DeleteById(id);
            return Ok();
        }
    }
}
