using HappyCoffee.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffee.Business.Abstract
{
    public interface IOrderService
    {
        Task<List<Order>> Orders();
        Task<Order> OrderById(int id);
        Task Update(Order order);
        Task Delete(int id);
        Task Add(Order order);
    }
}
