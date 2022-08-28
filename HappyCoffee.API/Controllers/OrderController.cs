using HappyCoffee.Business.Abstract;
using HappyCoffee.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyCoffee.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class OrderController : ControllerBase
    {
        private IOrderService _orderService { get; }

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("{id}")]
        public async Task< IActionResult> Order(int id)
        {
            var order = await _orderService.OrderById(id);
            return Ok(order);
        }

        [HttpGet]
        public async Task<IActionResult> Orders()
        {
            var orders = (await _orderService.Orders()).Where(x=>x.State == true);
            return Ok(orders);
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder(Order order)
        {
            await _orderService.Add(order);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrder(Order order)
        {
            await _orderService.Update(order);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Cancel(int id)
        {
            await _orderService.Delete(id);
            return Ok();
        }
    }
}
