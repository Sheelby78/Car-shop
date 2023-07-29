using carShop.Models;

namespace carShop.Repositories
{
    public interface IOrderRepository
    {
        Order? GetOrder(int id);
        int Create(Order order);
        bool Update(int id, Order order);
        bool Delete(int id);
    }
}
