using carShop.Models;
using carShop.Repositories;

namespace carShop.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public int Create(Order order)
        {
            var id = _orderRepository.Create(order);

            return id;
        }

        public bool Delete(int id)
        {
            var result = _orderRepository.Delete(id);

            return result;
        }

        public Order? GetById(int id)
        {
            var result = _orderRepository.GetOrder(id);

            return result;
        }

        public bool Update(int id, Order order)
        {
            var result = _orderRepository.Update(id, order);

            return result;
        }
    }
}
