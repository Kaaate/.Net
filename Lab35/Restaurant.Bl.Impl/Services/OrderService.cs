using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mapster;
using System.Threading.Tasks;
using Restaurant.Bl.Abstract.IMapper;
using Restaurant.Bl.Abstract.IServices;
using Restaurant.Dal.Abstract.Repository;
using Restaurant.Entities;
using Restaurant.Models;

namespace Restaurant.Bl.Impl.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }


        public async Task<List<OrderModel>> GetAll()
        {
            List<Order> result = await _orderRepository.GetAllAsync(x => true);
            return result.Adapt<List<OrderModel>>();
        }


        public async Task DeleteById(int id)
        {
            await _orderRepository.DeleteAsync(id);
        }

        public async Task Create(OrderModel model)
        {
            await _orderRepository.AddAsync(model.Adapt<Order>());
        }

        public async Task<OrderModel> GetByPhoneNumber(string phoneNumber)
        {
            Order result = (await _orderRepository.GetAllAsync(x => x.CustomerPhone == phoneNumber)).First();
            return result.Adapt<OrderModel>();
        }
 
    }
}
