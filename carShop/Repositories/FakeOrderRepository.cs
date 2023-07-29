using carShop.Models;

namespace carShop.Repositories
{
    public class FakeOrderRepository : IOrderRepository
    {
        private readonly ICollection<Order> orders = new List<Order>()
        {
            new (1, "111111111", "Wroclaw", "ulica", DateTime.Now),
            new (2, "222222222", "Krakow", "ulica", DateTime.Now),
            new (3, "333333333", "Warszawa", "ulica", DateTime.Now),
            new (4, "444444444", "Kielce", "ulica", DateTime.Now),
        };
        public int Create(Order order)
        {
            orders.Add(order);
            return order.Id;
        }

        public bool Delete(int id)
        {
            var orderToDelete = orders.First(x => x.Id == id);

            if (orderToDelete is null)
            {
                return false;
            }

            orders.Remove(orderToDelete);
            return true;
        }

        public Order? GetOrder(int id)
        {
            return orders.FirstOrDefault(x => x.Id == id);
        }

        public bool Update(int id, Order order)
        {
            var orderToUpdate = orders.FirstOrDefault(x => x.Id == id);

            if (orderToUpdate is null)
            {
                return false;
            }

            orderToUpdate.Phone = order.Phone;
            orderToUpdate.City = order.City;
            orderToUpdate.Address = order.Address;
            orderToUpdate.Date = order.Date;

            return true;
        }
    }
}
