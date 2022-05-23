using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Models;

namespace Restaurant.Bl.Abstract.IServices
{
    public interface IOrderService
    {
        Task<List<OrderModel>> GetAll();
        Task<OrderModel> GetByPhoneNumber(string phoneNumber);
        Task DeleteById(int id);
        Task Create(OrderModel model);
    }
}
