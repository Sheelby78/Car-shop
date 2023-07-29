using carShop.Models;
using carShop.Repositories;
using carShop.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace carShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetOrderById(int id)
        {
            var order = _orderService.GetById(id);

            if (order is null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            var id = _orderService.Create(order);

            return Created($"/api/car/{id}", order);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateOrder([FromRoute] int id, [FromBody] Order order)
        {
            var isSuccess = _orderService.Update(id, order);

            if (!isSuccess)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteOrder(int id)
        {
            var isSuccess = _orderService.Delete(id);

            if (!isSuccess)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
