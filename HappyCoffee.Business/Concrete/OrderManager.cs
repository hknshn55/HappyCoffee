using HappyCoffee.Business.Abstract;
using HappyCoffee.DataAccess.Abstract;
using HappyCoffee.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffee.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal { get; }

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public async Task Add(Order order)
        {
            order.State = true;
          await  _orderDal.Add(order);   
        }

        public async Task Delete(int id)
        {
            var order = await OrderById(id);
                order.State = false;
            await _orderDal.Update(order);
        }

        public async Task<Order> OrderById(int id)
        {
            return await _orderDal.Get(x => x.Id == id);
        }

        public async Task<List<Order>> Orders()
        {
            return await _orderDal.GetAll();
        }

        public async Task Update(Order order)
        {
            await _orderDal.Update(order);
        }
    }
}
