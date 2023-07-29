using carShop.Models;

namespace carShop.Services
{
    public interface IOrderService
    {
        Order? GetById(int id);
        int Create(Order order);
        bool Update(int id, Order order);
        bool Delete(int id);
    }
}
