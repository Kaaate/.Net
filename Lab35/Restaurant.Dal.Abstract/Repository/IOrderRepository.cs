using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Dal.Abstract.Repository.Base;
using Restaurant.Entities;

namespace Restaurant.Dal.Abstract.Repository
{
    public interface IOrderRepository : IGenericKeyRepository<int, Order>
    {

    }
}
